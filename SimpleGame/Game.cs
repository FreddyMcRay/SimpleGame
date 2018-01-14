using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace SimpleGame
{
    public class Game
    {
        private readonly List<Hero> _heroes;
        private string _key;

        public Game()
        {
            _heroes = new List<Hero>{new Lizard(), new Paper(), new Rock(), new Scissors(), new Spock()};
        }

        public void StartGame()
        {
            while (true)
            {
                var compHero =  MakeChoise();
                Console.WriteLine("Make your choise or write 'q' to quit");
                var playerChoise = Console.ReadLine();
                if(playerChoise.Equals("q")) break;
                try
                {
                    if (_heroes[Convert.ToInt32(playerChoise) - 1].Rules.Contains(compHero.Name))
                        Console.WriteLine(
                            $"You lose! Comp hero is: {compHero.Name}. The secret key is: {_key}");
                    else
                        Console.WriteLine(
                            $"You win! Comp hero is: {compHero.Name}. The secret key is: {_key}");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Wrong choise! Let's try again...");
                }
            }
            
        }

        private Hero MakeChoise()
        {
            _key = Path.GetRandomFileName().Replace(".", "");
            int pos = BitConverter.ToInt32(Encoding.ASCII.GetBytes(_key), 0);
            var hero = _heroes[pos < 0 ? pos % 5 * (-1) : pos % 5];
            Console.WriteLine($"Computer choise: {GenerateHmac(hero)}");
            return hero;
        }

        private string GenerateHmac(Hero hero)
        {
            var hmac = new HMACSHA256(Encoding.ASCII.GetBytes(_key));
            var hash = hmac.ComputeHash(Encoding.ASCII.GetBytes(hero.Name));
            return BitConverter.ToString(hash).Replace("-", "").ToLower();
        }
    }
}