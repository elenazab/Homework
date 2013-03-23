using System;

namespace Map.Tiles
{
    class Swamp:TypesOfForest
    {
        public Swamp()
        {
            tileColor = ConsoleColor.DarkMagenta;
            //if (rnd.Next(1, 20) < 15)
            //{
            //    tileHasTree = true;
            //    tree = new SwampTree();
            //    tileIcon = tree.TreeIcon;
            //}
        }

        protected override Woods GetTree()
        {
            return new SwampTree();
        }

        public override Tile Clone()
        {
            return new Swamp();
        }
    }
}
