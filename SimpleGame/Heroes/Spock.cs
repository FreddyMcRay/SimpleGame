using System.Collections.Generic;

namespace SimpleGame
{
    public class Spock : Hero
    {
        public override string Name => "Spock";
        public override List<string> Rules => new List<string>{"Lizard", "Paper"};
    }
}