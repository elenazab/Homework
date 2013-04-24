using System;

namespace Map
{
    abstract class Terrain
    {

        protected ConsoleColor color;

        public ConsoleColor Color
        {
            get
            {
                return color;
            }
        }

        protected char icon;

        public char Icon
        {
            get
            {
                return icon;
            }
        }

    }
}
