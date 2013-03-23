using System;

namespace Map
{
    class Character: Tile
    {
        public Character()
        {
            tileIcon = ' ';
            tileColor = ConsoleColor.White;
            //CoordinateX = x;
            //CoordinateY = y;
        }

        public override Tile Clone()
        {
            return new Character();
        }

        //public int CoordinateX {get; set; }////////////////////
        //public int CoordinateY { get; set; }////////////////////
    }
}
