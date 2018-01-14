using System.Collections.Generic;

namespace SimpleGame
{
    public class Lizard : Hero
    {
        public override string Name => "Lizard";
        public override List<string> Rules => new List<string>{"Rock", "Scissors"};
    }
}