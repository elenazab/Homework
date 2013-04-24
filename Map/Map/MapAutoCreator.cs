using System;

namespace Map
{
    class MapAutoCreator: MapCreator
    {
        public Map AutoCreator(int mapSize)
        {
            this.mapSize = mapSize;
            newMap = new Map(mapSize);
            notWaterTile = 0;
            while (notWaterTile < mapSize * mapSize * 6 / 7)//цифры изменить на что
            {
                this.CreateObject(new Field());
                this.CreateObject(new Forest());
                this.CreateObject(new Swamp());
            }
            this.RemoveIsolatedTwoTileGroup();
            this.DeleteSingleTile();
            //this.AddTree();
            return newMap;
        }

        private void CreateObject(Terrain terrainType)
        {
            this.Growing(rnd.Next(0, mapSize), rnd.Next(0, mapSize), terrainType);
        }

        private void Growing(int i, int j, Terrain terrainType)
        {
            this.AddTile(i + 1, j, terrainType);
            this.AddTile(i - 1, j, terrainType);
            this.AddTile(i, j + 1, terrainType);
            this.AddTile(i, j - 1, terrainType);
        }

        private void AddTile(int i, int j, Terrain terrainType)
        {
            if (rnd.Next(0, 5) > 2
                && i >= 0 && i < mapSize && j >= 0 && j < mapSize
                && newMap.mapArray[i][j].Terrain is Water)
            {
                newMap.mapArray[i][j] = new Tile(terrainType);
                this.Growing(i, j, terrainType);
                notWaterTile++;
            }
        }

        private void DeleteSingleTile()
        {
            for (var i = 1; i < mapSize - 1; i++)
            {
                for (var j = 1; j < mapSize - 1; j++)
                {
                    if (newMap.mapArray[i][j].Terrain.Color != newMap.mapArray[i + 1][j].Terrain.Color//сделать сравнение по классу
                        && newMap.mapArray[i][j].Terrain.Color != newMap.mapArray[i - 1][j].Terrain.Color
                        && newMap.mapArray[i][j].Terrain.Color != newMap.mapArray[i][j + 1].Terrain.Color
                        && newMap.mapArray[i][j].Terrain.Color != newMap.mapArray[i][j - 1].Terrain.Color)
                    {
                        newMap.mapArray[i][j] = new Tile(newMap.mapArray[i + 1][j].Terrain);////нееееее
                    }
                }
            }
        }

        private void RemoveIsolatedTwoTileGroup()
        {
            for (var i = 2; i < mapSize - 2; i++)
            {
                for (var j = 2; j < mapSize - 2; j++)
                {
                    if (Count(i, j) < 3)
                    {
                        newMap.mapArray[i - 1][j] = new Tile(newMap.mapArray[i - 2][j].Terrain);
                        newMap.mapArray[i + 1][j] = new Tile(newMap.mapArray[i + 2][j].Terrain);
                        newMap.mapArray[i][j - 1] = new Tile(newMap.mapArray[i][j - 2].Terrain);
                        newMap.mapArray[i][j + 1] = new Tile(newMap.mapArray[i][j + 2].Terrain);
                    }
                }
            }
        }

        private int Count(int i, int j)
        {
            var tmp = 0;
            if (newMap.mapArray[i][j].Terrain.Color == newMap.mapArray[i][j - 1].Terrain.Color)
                tmp++;
            if (newMap.mapArray[i][j].Terrain.Color == newMap.mapArray[i][j + 1].Terrain.Color)
                tmp++;
            if (newMap.mapArray[i][j].Terrain.Color == newMap.mapArray[i - 1][j].Terrain.Color)
                tmp++;
            if (newMap.mapArray[i][j].Terrain.Color == newMap.mapArray[i + 1][j].Terrain.Color)
                tmp++;
            return tmp;
        }

        private int mapSize;
        private int notWaterTile;
        private Map newMap;
        private Random rnd = SingletonRandom.Instance();
    }
}
