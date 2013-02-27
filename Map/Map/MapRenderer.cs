using System;

namespace Map
{
    class MapRenderer
    {
        public MapRenderer(Map map, int x, int y)
        {
            //consoleSize = 10;//42
            Console.Title = "Map";
            Console.Clear();
            this.DisplayMap(map);
            this.DisplayMenu();
        }

        private void DisplayMap(Map map)
        {
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

        //private void DisplayMap(Map map, int x, int y)
        //{
        //    for (var i = x - consoleSize; i < x + consoleSize; i++)
        //    {
        //        for (var j = y - consoleSize; j < y + consoleSize; j++)
        //        {
        //            if (i >= 0 && i < map.MapSize && j >= 0 && j < map.MapSize)
        //            {
        //                Console.ForegroundColor = map.mapArray[i][j].Color;
        //                Console.Write(map.mapArray[i][j].Icon);
        //            }
        //        }
        //        Console.WriteLine(' ');
        //    }
        //}

        private void DisplayMenu()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Menu \n ");
        }

        //private int consoleSize;
        //private int coordinateX;
        //private int coordinateY;
    }
}
