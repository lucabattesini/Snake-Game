using Game;
class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.BackgroundColor = ConsoleColor.Black;
        
        GameRunner game = new GameRunner();

        game.Run();
    }
}