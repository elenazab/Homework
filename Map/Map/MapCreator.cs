﻿using System;

namespace Map
{
    class MapCreator
    {
        public MapCreator(int mapSize)
        {
            this.mapSize = mapSize;
            newMap = new Map(mapSize);
            while (notWaterTile < mapSize * mapSize * 6 / 7)//цифры изменить на что
            {
                this.CreateObject(new Field());
                this.CreateObject(new Forest());
            }
            this.RemoveIsolatedTwoTileGroup();
            this.DeleteSingleTile();
        }

        private void CreateObject(Tile tileType)
        {
            this.Growing(rnd.Next(0, mapSize), rnd.Next(0, mapSize), tileType);
        }

        private void Growing(int i, int j, Tile tileType)
        {
            this.AddTile(i + 1, j, tileType);
            this.AddTile(i - 1, j, tileType);
            this.AddTile(i, j + 1, tileType);
            this.AddTile(i, j - 1, tileType);//еще можно добавить клетки по диаг
            //нельзя
        }

        private void AddTile(int i, int j, Tile tileType)
        {
            if (rnd.Next(0, 5) > 2 
                && i >= 0 && i < mapSize && j >= 0 && j < mapSize
                && newMap.mapArray[i][j].Icon == '~')
            {
                newMap.mapArray[i][j] = tileType;
                this.Growing(i, j, tileType);
                notWaterTile++;
            }
        }

        private void DeleteSingleTile()
        {
            for (var i = 1; i < mapSize - 1; i++)
            {
                for (var j = 1; j < mapSize - 1; j++)
                {
                    if (newMap.mapArray[i][j].Icon != newMap.mapArray[i + 1][j].Icon
                        && newMap.mapArray[i][j].Icon != newMap.mapArray[i - 1][j].Icon
                        && newMap.mapArray[i][j].Icon != newMap.mapArray[i][j+1].Icon
                        && newMap.mapArray[i][j].Icon != newMap.mapArray[i][j-1].Icon)
                    {
                        newMap.mapArray[i][j]= newMap.mapArray[i + 1][j];
                    }
                }
            }
        }

        private void RemoveIsolatedTwoTileGroup()
        {
            for (var i = 2; i < mapSize-2; i++)
            {
                for (var j = 2; j < mapSize-2; j++)
                {
                    if (Count(i, j) < 3)
                    {
                        newMap.mapArray[i - 1][j] = newMap.mapArray[i -2][j];
                        newMap.mapArray[i + 1][j] = newMap.mapArray[i + 2][j];
                        newMap.mapArray[i][j-1] = newMap.mapArray[i][j-2];
                        newMap.mapArray[i][j+1] = newMap.mapArray[i][j+2];
                    }
                }
            }
        }

        private int Count (int i, int j)
        {
            var tmp = 0;
            if (newMap.mapArray[i][j].Icon == newMap.mapArray[i][j - 1].Icon)
                tmp++;
            if (newMap.mapArray[i][j].Icon == newMap.mapArray[i][j + 1].Icon)
                tmp++;
            if (newMap.mapArray[i][j].Icon == newMap.mapArray[i-1][j].Icon)
                tmp++;
            if (newMap.mapArray[i][j].Icon == newMap.mapArray[i+1][j].Icon)
                tmp++;
            return tmp;
        }

        private Random rnd = new Random();
        private int notWaterTile;
        private Map newMap;
        public Map NewMap
        {
            get
            {
                return newMap;
            }
        }
        private int mapSize;
    }
}