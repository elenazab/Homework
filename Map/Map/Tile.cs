using System;


namespace Map
{
    class Tile
    {
        protected char icon;

        public char Icon
    {
        get
        {
            return icon;
        }
    }

        protected ConsoleColor color;

        public ConsoleColor Color
        {
            get
        {
            return color;
        }
        }
    }
}
