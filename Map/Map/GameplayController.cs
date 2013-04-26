using System;
using System.Collections.Generic;
using System.Linq;

namespace Map
{
    class GameplayController
    {
        public GameplayController()
        {
            mapSize = 40;
            allObjectsOnMap = new List<MapObject>();
            var CreateMap = new MapAutoCreator();
            var testMap = CreateMap.AutoCreator(mapSize, this);
            var renderer = new MapRenderer(testMap, 20, 20);
        }

        public void AddObject(MapObject newObject)
        {
            allObjectsOnMap.Add(newObject);
        }

        private Random rnd = SingletonRandom.Instance();
        private int mapSize;
        private List<MapObject> allObjectsOnMap;
    }
}
