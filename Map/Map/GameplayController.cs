using System;
using System.Collections.Generic;
using System.Linq;

namespace Map
{
    class GameplayController
    {
        public GameplayController()
        {
            mapSize = 20;
            var mapCreator = new MapCreator();
            map = mapCreator.AutoCreator(mapSize, this);
        }

        public void StartGame()
        {
            //var renderer = new MapRenderer(map, 20, 20);
            this.AddPlayer();
            this.AddPlayer();
            this.Run();
        }

        private void AddPlayer()
        {
            var me = new StonedCat();
            me.SetBehavior(new PlayerDecisionMaker(me));//это и есть обдолбанность
            this.AddObject(me);
            var i = rnd.Next(0, mapSize);
            var j = rnd.Next(0, mapSize);
            while (map.mapArray[i][j].Terrain is Water)//и еще что-нибудь
            {
                i = rnd.Next(0, mapSize);
                j = rnd.Next(0, mapSize);
            }
            map.mapArray[i][j].listOfObjects.Add(me);
            me.CoordinateX = i;
            me.CoordinateY = j;
        }

        public void AddObject(MapObject newObject)
        {
            allObjectsOnMap.Add(newObject);
        }

        private void Run()
        {
            while (true)
            {
                foreach(MapObject obj in allObjectsOnMap)
                {
                    obj.MakeMove(map);
                }
            }
        }

        private Random rnd = SingletonRandom.Instance();
        private readonly int mapSize;
        private List<MapObject> allObjectsOnMap = new List<MapObject>();
        private Map map;
    }
}
