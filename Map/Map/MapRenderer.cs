using System;

namespace Map
{
    class MapRenderer
    {
        public MapRenderer(Map map)
        {
            Console.Title = "Map";
            Console.Clear();
            for (var i = 0; i < map.MapSize; i++)
            {
                for (var j = 0; j < map.MapSize; j++)
                {
                    Console.ForegroundColor = map.mapArray[i][j].Color;
                    Console.Write(map.mapArray[i][j].Icon);
                }
                Console.WriteLine(' ');
            }
        }
    }
}
