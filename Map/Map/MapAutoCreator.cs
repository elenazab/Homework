using System;

namespace Map
{
    class MapCreator
    {
        public Map AutoCreator(int mapSize, GameplayController controller)
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
            this.AddTree(controller);
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
                    if (!this.EqTiles(i, j, i + 1, j)
                        && !this.EqTiles(i, j, i - 1, j)
                        && !this.EqTiles(i, j, i, j + 1)
                        && !this.EqTiles(i, j, i, j - 1))
                    {
                        newMap.mapArray[i][j] = newMap.mapArray[i + 1][j].CloneTile();
                    }
                }
            }
        }

        private bool EqTiles(int i1, int j1, int i2, int j2)
        {
             return newMap.mapArray[i1][j1].Terrain.GetType() == newMap.mapArray[i2][j2].Terrain.GetType();
        }

        private void RemoveIsolatedTwoTileGroup()
        {
            for (var i = 2; i < mapSize - 2; i++)
            {
                for (var j = 2; j < mapSize - 2; j++)
                {
                    if (Count(i, j) < 3)
                    {
                        newMap.mapArray[i - 1][j] = newMap.mapArray[i - 2][j].CloneTile();
                        newMap.mapArray[i + 1][j] = newMap.mapArray[i + 2][j].CloneTile();
                        newMap.mapArray[i][j - 1] = newMap.mapArray[i][j - 2].CloneTile();
                        newMap.mapArray[i][j + 1] = newMap.mapArray[i][j + 2].CloneTile();
                    }
                }
            }
        }

        private int Count(int i, int j)
        {
            var tmp = 0;
            if (this.EqTiles(i, j, i, j - 1))
                tmp++;
            if (this.EqTiles(i, j, i, j + 1))
                tmp++;
            if (this.EqTiles(i, j, i - 1, j))
                tmp++;
            if (this.EqTiles(i, j, i + 1, j))
                tmp++;
            return tmp;
        }

        private void AddTree(GameplayController controller)
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
                            newObject = new ForestTree();
                        }
                        if (newMap.mapArray[i][j].Terrain is Swamp)
                        {
                            newObject = new SwampTree();
                        }
                        if (newMap.mapArray[i][j].Terrain is Field)
                        {
                            newObject = new FieldTree();
                        }
                        if (newObject != null)
                        {
                            newObject.SetBehavior(new RandomDecisionMaker());
                            newMap.mapArray[i][j].listOfObjects.Add(newObject);
                            controller.AddObject(newObject);
                            newObject.CoordinateX = i;
                            newObject.CoordinateY = j;
                        }
                    }
                }
            }
        }

        private int mapSize;
        private int notWaterTile;
        private Map newMap;
        private Random rnd = SingletonRandom.Instance();
    }
}
