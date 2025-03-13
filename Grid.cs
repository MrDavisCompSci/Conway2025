using System;
namespace _2022_A3_GameOfLife
{
	public class Grid
	{
		// Attributes
		int width;
		int height;
		Cell[,] gameState;

		public Grid(int w, int h)
		{
			width = w;
			height = h;
			gameState = new Cell[width + 2, height + 2];
			InitialiseGrid();
		}

		private void InitialiseGrid()
		{
			for (int rows = 0; rows < height + 2; rows++)
			{
				for (int cols = 0; cols < width + 2; cols++)
				{
					Cell temp = new Cell(cols, rows);
					gameState[cols, rows] = temp;
				}
			}
		}

		public void Display()
		{
			for (int rows = 1; rows < height; rows++)
			{
				for (int cols = 1; cols < width; cols++)
				{
					// call the Display method of the Cell
					gameState[cols, rows].Display();
				}
				Console.WriteLine();
			}
		}

		public void DisplayNeighbours()
		{
            for (int rows = 1; rows < height; rows++)
            {
                for (int cols = 1; cols < width; cols++)
                {
                    // call the GetNeighbours method of the Cell
                    int n = gameState[cols, rows].GetNeighbours();
					Console.Write(n);
                }
                Console.WriteLine();
            }
        }

		public void SpawnAt(int x, int y)
		{
			gameState[x, y].MakeAlive();
		}

		public void Update()
		{
			UpdateNeighbourCounts();

			// more to come here!
			for (int y = 1; y < height; y++)
			{
				for (int x = 1; x < width; x++)
				{
					if (gameState[x,y].IsAlive() &&
						gameState[x,y].GetNeighbours() < 2)
					{
						gameState[x, y].MakeDead();
					}
					else if (gameState[x,y].IsAlive() &&
						gameState[x,y].GetNeighbours() > 3)
					{
						gameState[x, y].MakeDead();
					}
					else if (gameState[x,y].IsAlive())
					{
						gameState[x, y].MakeAlive();
					}
					else if (!gameState[x,y].IsAlive() &&
						gameState[x,y].GetNeighbours() == 3)
					{
						gameState[x, y].MakeAlive();
					}
				}
			}
		}

		private void UpdateNeighbourCounts()
		{
			int count;

			for (int y = 1; y < height; y++)
			{
				for (int x = 1; x < width; x++)
				{
					count = CountNeighbours(x, y);
					gameState[x, y].SetNeighbours(count);
				}
			}
		}

		private int CountNeighbours(int x, int y)
		{
			int count = 0;

			for(int rows = -1; rows < 2; rows++)
			{
				for(int cols =-1; cols < 2; cols++)
				{
					if (gameState[x + cols, y + rows].IsAlive())
					{
						count++;
					}
				}
			}

			// don't count centre cell f it is alive!
			if (gameState[x,y].IsAlive())
			{
				count--;
			}

			return count;
		}
	}
}

