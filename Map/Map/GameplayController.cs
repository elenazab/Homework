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
            var renderer = new MapRenderer(map, 20, 20);
            this.AddPlayer();
            this.Run(renderer);
        }

        private void AddPlayer()
        {
            var me = new StonedCat(new PlayerDecisionMaker());
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

        private void Run(MapRenderer renderer)
        {
            while (true)
            {
                foreach(MapObject obj in allObjectsOnMap)
                {
                    if (obj is StonedCat)
                    {
                        renderer.DisplayObject(obj);
                    }
                    var objDecision = obj.MakeMove(map);
                    if (obj is StonedCat)
                    {
                        renderer.DisplayMenu(map, obj.objectSound);
                        renderer.DisplayObject(obj);
                    }
                    if (objDecision == Decision.WishUp && obj.CoordinateY > 0)
                    {
                        map.mapArray[obj.CoordinateX][obj.CoordinateY - 1].listOfObjects.Add(obj);
                        map.mapArray[obj.CoordinateX][obj.CoordinateY].listOfObjects.Remove(obj);
                        obj.CoordinateY -= 1;
                        renderer.DisplayTile(map, obj.CoordinateX, obj.CoordinateY + 1);
                        renderer.DisplayTile(map, obj.CoordinateX, obj.CoordinateY);
                    }
                    if (objDecision == Decision.WishRight && obj.CoordinateX < mapSize - 1)
                    {
                        map.mapArray[obj.CoordinateX + 1][obj.CoordinateY].listOfObjects.Add(obj);
                        map.mapArray[obj.CoordinateX][obj.CoordinateY].listOfObjects.Remove(obj);
                        obj.CoordinateX += 1;
                        renderer.DisplayTile(map, obj.CoordinateX - 1, obj.CoordinateY);
                        renderer.DisplayTile(map, obj.CoordinateX, obj.CoordinateY);
                    }
                    if (objDecision == Decision.WishDown && obj.CoordinateY < mapSize - 1)
                    {
                        map.mapArray[obj.CoordinateX][obj.CoordinateY + 1].listOfObjects.Add(obj);
                        map.mapArray[obj.CoordinateX][obj.CoordinateY].listOfObjects.Remove(obj);
                        obj.CoordinateY += 1;
                        renderer.DisplayTile(map, obj.CoordinateX, obj.CoordinateY - 1);
                        renderer.DisplayTile(map, obj.CoordinateX, obj.CoordinateY);
                    }
                    if (objDecision == Decision.WishLeft && obj.CoordinateX > 0)
                    {
                        map.mapArray[obj.CoordinateX - 1][obj.CoordinateY].listOfObjects.Add(obj);
                        map.mapArray[obj.CoordinateX][obj.CoordinateY].listOfObjects.Remove(obj);
                        obj.CoordinateX -= 1;
                        renderer.DisplayTile(map, obj.CoordinateX+1, obj.CoordinateY);
                        renderer.DisplayTile(map, obj.CoordinateX, obj.CoordinateY);
                    }
                }
            }
        }

        private Random rnd = SingletonRandom.Instance();
        private readonly int mapSize;
        private List<MapObject> allObjectsOnMap = new List<MapObject>();
        private Map map;
    }
}
