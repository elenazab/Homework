using System;


namespace Map
{
    abstract class Tile
    {
        protected char tileIcon;

        public char TileIcon
        {
            get
            {
                return tileIcon;
            }
        }

        protected ConsoleColor tileColor;

        public ConsoleColor TileColor
        {
            get
            {
                return tileColor;
            }
        }

        public abstract Tile Clone();
    }
}
