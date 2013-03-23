using System;

namespace Map
{
    class Forest: TypesOfForest
    {
        public Forest()
        {
            ////tileIcon = ' ';
            tileColor = ConsoleColor.DarkGreen;
            ////Random rnd = new Random();
            //if (rnd.Next(1, 20) > 8)
            //{
            //    tileHasTree = true;
            //    tree = new ForestTree();
            //    tileIcon = tree.TreeIcon;
            //}
            //else
            //{
            //    tileHasTree = false;
            //    tileIcon = ' ';
            //}
        }

        protected override Woods GetTree()
        {
            return new ForestTree();
        }

        public override Tile Clone()
        {
            return new Forest();
        }
    }
}
