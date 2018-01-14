using System;

namespace SimpleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - 'Lizard', 2 - 'Paper', 3 - 'Rock', 4 - 'Scissors', 5 - 'Spock'");
            var game = new Game();
            game.StartGame();
            Console.WriteLine("Bye!");
        }
    }
}