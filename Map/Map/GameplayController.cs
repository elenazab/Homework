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

        private void Run(Map testMap)
        {
            while (true)
            {
                foreach(MapObject obj in allObjectsOnMap)
                {
                    var objDecision = obj.MakeMove(testMap);
                    if (objDecision == (Decision)(1))
                    {
                        testMap.mapArray[obj.CoordinateX][obj.CoordinateY - 1].listOfObjects.Add(obj);
                        testMap.mapArray[obj.CoordinateX][obj.CoordinateY].listOfObjects.Remove(obj);
                        obj.CoordinateY -= 1;
                    }
                    if (objDecision == (Decision)(2))
                    {
                        testMap.mapArray[obj.CoordinateX + 1][obj.CoordinateY].listOfObjects.Add(obj);
                        testMap.mapArray[obj.CoordinateX][obj.CoordinateY].listOfObjects.Remove(obj);
                        obj.CoordinateX += 1;
                    }
                    if (objDecision == (Decision)(3))
                    {
                        testMap.mapArray[obj.CoordinateX][obj.CoordinateY + 1].listOfObjects.Add(obj);
                        testMap.mapArray[obj.CoordinateX][obj.CoordinateY].listOfObjects.Remove(obj);
                        obj.CoordinateY += 1;
                    }
                    if (objDecision == (Decision)(4))
                    {
                        testMap.mapArray[obj.CoordinateX - 1][obj.CoordinateY].listOfObjects.Add(obj);
                        testMap.mapArray[obj.CoordinateX][obj.CoordinateY].listOfObjects.Remove(obj);
                        obj.CoordinateX -= 1;
                    }
                }
            }
        }

        private Random rnd = SingletonRandom.Instance();
        private int mapSize;
        private List<MapObject> allObjectsOnMap;
    }
}
