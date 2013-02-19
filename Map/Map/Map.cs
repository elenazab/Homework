using System;

namespace Map
{
    class Map
    {
        public Map(int mapSize)
        {
            this.mapArray = new Tile[mapSize][];
            for (var i = 0; i < mapSize; i++)
            {
                mapArray[i] = new Tile[mapSize];
            }
            for (var i = 0; i < mapSize; i++)
            {
                for (var j = 0; j < mapSize; j++)
                {
                    mapArray[i][j] = new Water();//??????
                }
            }
        }

        public Tile[][] mapArray {get; set;}
        public int MapSize
        {
            get
            {
                return mapArray.Length;
            }
        }
    }
}
 
