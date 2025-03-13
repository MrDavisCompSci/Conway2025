namespace GameOfLife;
class Program
{
    static void Main(string[] args)
    {
        const int WIDTH = 30;
        const int HEIGHT = 20;

        Grid game = new Grid(WIDTH, HEIGHT);

        //game.Display();

        // Create an intial pattern
        game.SpawnAt(15, 9);
        game.SpawnAt(15, 10);
        game.SpawnAt(15, 11);
        game.SpawnAt(14, 11);
        game.SpawnAt(13, 10);

        //game.Display();

        // Game loop!
        while(true)
        {
            Console.Clear();

            game.Display();

            game.Update();

            //game.DisplayNeighbours();

            Console.WriteLine("Press enter for next generation");
            Console.ReadKey();
        }
    }
}
