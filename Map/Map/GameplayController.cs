﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Map
{
    class GameplayController
    {
        public GameplayController()
        {
            mapSize = 20;
            allObjectsOnMap = new List<MapObject>();
            var CreateMap = new MapAutoCreator();
            var testMap = CreateMap.AutoCreator(mapSize, this);
            var renderer = new MapRenderer(testMap, 20, 20);
            this.AddPlayer(testMap);
            this.Run(testMap, renderer);
        }

        private void AddPlayer(Map map)
        {
            var me = new StonedCat(new PlayerDecisionMaker());
            allObjectsOnMap.Add(me);
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

        private void Run(Map testMap, MapRenderer renderer)
        {
            while (true)
            {
                foreach(MapObject obj in allObjectsOnMap)
                {
                    //renderer.DisplayObject(obj);
                    //Console.ReadKey();
                    var objDecision = obj.MakeMove(testMap);
                    if (obj is StonedCat)
                    {
                        renderer.DisplayMenu(testMap, obj.objectSound);
                        renderer.DisplayObject(obj);
                    }
                    if (objDecision == (Decision)(1) && obj.CoordinateY > 0)
                    {
                        testMap.mapArray[obj.CoordinateX][obj.CoordinateY - 1].listOfObjects.Add(obj);
                        testMap.mapArray[obj.CoordinateX][obj.CoordinateY].listOfObjects.Remove(obj);
                        obj.CoordinateY -= 1;
                        renderer.DisplayTile(testMap, obj.CoordinateX, obj.CoordinateY + 1);
                        renderer.DisplayTile(testMap, obj.CoordinateX, obj.CoordinateY);
                    }
                    if (objDecision == (Decision)(2) && obj.CoordinateX < mapSize - 1)
                    {
                        testMap.mapArray[obj.CoordinateX + 1][obj.CoordinateY].listOfObjects.Add(obj);
                        testMap.mapArray[obj.CoordinateX][obj.CoordinateY].listOfObjects.Remove(obj);
                        obj.CoordinateX += 1;
                        renderer.DisplayTile(testMap, obj.CoordinateX - 1, obj.CoordinateY);
                        renderer.DisplayTile(testMap, obj.CoordinateX, obj.CoordinateY);
                    }
                    if (objDecision == (Decision)(3) && obj.CoordinateY < mapSize - 1)
                    {
                        testMap.mapArray[obj.CoordinateX][obj.CoordinateY + 1].listOfObjects.Add(obj);
                        testMap.mapArray[obj.CoordinateX][obj.CoordinateY].listOfObjects.Remove(obj);
                        obj.CoordinateY += 1;
                        renderer.DisplayTile(testMap, obj.CoordinateX, obj.CoordinateY - 1);
                        renderer.DisplayTile(testMap, obj.CoordinateX, obj.CoordinateY);
                    }
                    if (objDecision == (Decision)(4) && obj.CoordinateX > 0)
                    {
                        testMap.mapArray[obj.CoordinateX - 1][obj.CoordinateY].listOfObjects.Add(obj);
                        testMap.mapArray[obj.CoordinateX][obj.CoordinateY].listOfObjects.Remove(obj);
                        obj.CoordinateX -= 1;
                        renderer.DisplayTile(testMap, obj.CoordinateX+1, obj.CoordinateY);
                        renderer.DisplayTile(testMap, obj.CoordinateX, obj.CoordinateY);
                    }
                }
            }
        }

        private Random rnd = SingletonRandom.Instance();
        private int mapSize;
        private List<MapObject> allObjectsOnMap;
    }
}