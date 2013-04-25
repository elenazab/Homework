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
            var testMap = CreateMap.AutoCreator(mapSize);
            this.AddTree(testMap);
            var renderer = new MapRenderer(testMap, 20, 20);
        }
/// <summary>
/// дальше можно не читать :)
/// </summary>
/// <param name="newMap"></param>
        private void AddTree(Map newMap)
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (rnd.Next(0, 15) > 5)// параметр лесистости
                    {
                        MapObject newObject = null;
                        if (newMap.mapArray[i][j].Terrain is Forest)
                        {
                            newObject = new ForestTree(new RandomDecisionMaker());
                        }
                        if (newMap.mapArray[i][j].Terrain is Swamp)
                        {
                            newObject = new SwampTree(new RandomDecisionMaker());
                        }
                        if (newMap.mapArray[i][j].Terrain is Field)
                        {
                            newObject = new FieldTree(new RandomDecisionMaker());
                        }
                        if (newObject != null)
                        {
                            newMap.mapArray[i][j].listOfObjects.Add(newObject);
                            allObjectsOnMap.Add(newObject);
                        }
                    }
                }
            }
        }

        private Random rnd = SingletonRandom.Instance();
        private int mapSize;
        private List<MapObject> allObjectsOnMap;
    }
}
