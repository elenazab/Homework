using System;

namespace Map
{
    class SingletonRandom
    {
        public static Random Instance()
        {
            if (instance == null)
            {
                instance = new Random();
            }
            return instance;
        }

        private static Random instance;
    }
}
