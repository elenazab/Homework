using System;

namespace Map
{
    class Field: TypesOfForest
    {
        public Field()
        {
            tileColor = ConsoleColor.DarkYellow;
            //if (rnd.Next(1, 20) < 15)
            //{
            //    tileHasTree = true;
            //    tree = new FieldTree();
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
            return new FieldTree();
        }

        public override Tile Clone()
        {
            return new Field();
        }

    }
}
