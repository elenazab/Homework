using System;
using System.Collections.Generic;

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
                        if (newMap.mapArray[i][j].Terrain is Forest)
                        {
                            newMap.mapArray[i][j].listOfObjects.Add(new ForestTree(new RandomDecisionMaker()));
                            allObjectsOnMap.Add(newMap.mapArray[i][j].listOfObjects[newMap.mapArray[i][j].listOfObjects.Count - 1]);//ЖЕСТЬ!!!!!
                        }
                        if (newMap.mapArray[i][j].Terrain is Swamp)
                        {
                            newMap.mapArray[i][j].listOfObjects.Add(new SwampTree(new RandomDecisionMaker()));
                            allObjectsOnMap.Add(newMap.mapArray[i][j].listOfObjects[newMap.mapArray[i][j].listOfObjects.Count - 1]);
                        }
                        if (newMap.mapArray[i][j].Terrain is Field)
                        {
                            newMap.mapArray[i][j].listOfObjects.Add(new FieldTree(new RandomDecisionMaker()));
                            allObjectsOnMap.Add(newMap.mapArray[i][j].listOfObjects[newMap.mapArray[i][j].listOfObjects.Count - 1]);
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
