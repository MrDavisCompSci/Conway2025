namespace GameOfLife;
class Program
{
    static void Main(string[] args)
    {
        const int WIDTH = 50;
        const int HEIGHT = 50;

        Grid game = new Grid(WIDTH, HEIGHT);

        // Create an intial glider pattern
        //game.SpawnAt(15, 9);
        //game.SpawnAt(15, 10);
        //game.SpawnAt(15, 11);
        //game.SpawnAt(14, 11);
        //game.SpawnAt(13, 10);

        // start with a new shape from the PatternCollection
        foreach((int,int) coord in PatternCollection.GetPattern("gosper"))
        {
            game.SpawnAt(coord.Item1,coord.Item2);    
        }
        
        // Game loop!
        while(true)
        {
            Console.Clear();

            game.Display();
            game.Update();

            Console.WriteLine("Press enter for next generation");
            Console.ReadKey();
        }
    }
}
