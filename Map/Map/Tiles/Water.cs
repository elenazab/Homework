using System;

namespace Map
{
    class Water: Tile
    {
        public Water()
        {
            tileIcon = '~';
            tileColor = ConsoleColor.DarkBlue;
        }

        public override Tile Clone()
        {
            return new Water();
        }
    }
}
