using System;

namespace Map
{
    class RandomDecisionMaker:Behavior
    {
        public override Decision Think(Map map)
        {
            return (Decision)(rnd.Next(5));
        }

        private Random rnd = SingletonRandom.Instance();
    }
}
