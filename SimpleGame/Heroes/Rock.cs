using System.Collections.Generic;

namespace SimpleGame
{
    public class Rock : Hero
    {
        public override string Name => "Rock";
        public override List<string> Rules => new List<string>{"Spock", "Paper"};
    }
}