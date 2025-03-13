using System;
namespace _2022_A3_GameOfLife
{
	public class Cell
	{
		// attributes
		private int xPos;
		private int yPos;
		private bool alive;
		private int neighbours;

		public Cell(int x, int y)
		{
			xPos = x;
			yPos = y;
            alive = false;
            neighbours = 0;
		}

		public void Display()
		{
			if(alive)
			{
				Console.Write('O');
			}
			else
			{
				Console.Write('.');
			}
		}

		public void MakeAlive()
		{
			alive = true;
		}

		public void MakeDead()
		{
			alive = false;
		}

		public void Toggle()
		{
			alive = !alive;
		}

		public void SetNeighbours(int n)
		{
			neighbours = n;
		}

		public int GetNeighbours()
		{
			return neighbours;
		}

		public bool IsAlive()
		{
			return alive;
		}
	}
}

