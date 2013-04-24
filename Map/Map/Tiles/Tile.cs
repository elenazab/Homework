using System;
using System.Collections.Generic;


namespace Map
{
    class Tile
    {
        public Tile(Terrain terrain)
        {
            this.terrain = terrain;
            listOfObjects = new List<MapObject>();
        }

        public Tile CloneTile()
        {
            return new Tile(terrain);
        }

        public List<MapObject> listOfObjects;//убрать
        private Terrain terrain;
        public Terrain Terrain
        {
            get
            {
                return terrain;
            }
        }
    }
}
