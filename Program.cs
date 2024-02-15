
namespace Minecraft_clone
{

    class Program
    {
        // Entry point of the program
        static void Main(string[] args)
        {
            // Creates game object and disposes of it after leaving the scope
            using(Game game = new Game(500, 500))
            {
                // Running the game
                game.Run();
            }
        }
    }
}