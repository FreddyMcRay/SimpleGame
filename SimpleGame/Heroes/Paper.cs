using System.Collections.Generic;

namespace SimpleGame
{
    public class Paper : Hero
    {
        public override string Name => "Paper";
        public override List<string> Rules => new List<string>{"Scissors", "Lizard"};
    }
}