using System.Collections.Generic;

namespace SimpleGame
{
    public abstract class Hero
    {
        public abstract string Name { get; }
        public abstract List<string> Rules { get; }
    }
}