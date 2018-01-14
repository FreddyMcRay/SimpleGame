using System.Collections.Generic;

namespace SimpleGame
{
    public class Scissors : Hero
    {
        public override string Name => "Scissors";
        public override List<string> Rules => new List<string>{"Rock", "Spock"};
    }
}