using System;

namespace Map
{
    abstract class TypesOfForest: Tile
    {
        public TypesOfForest()
        {
            //tileIcon = ' ';
            //tileColor = ConsoleColor.DarkGreen;
            //Random rnd = new Random();
            this.Init();
        }

        private void Init()
        {
            if (rnd.Next(1, 20) > 5)
            {
                tileHasTree = true;
                tree = GetTree();
                tileIcon = tree.TreeIcon;
            }
            else
            {
                tileHasTree = false;
                tileIcon = ' ';
            }
        }

        protected abstract Woods GetTree();

        public bool tileHasTree;//ДААААА!!!!!!1111
        protected Woods tree;
        private Random rnd = SingletonRandom.Instance();
    }
}
