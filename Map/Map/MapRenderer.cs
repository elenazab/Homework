using System;

namespace Map
{
    class MapRenderer
    {
        public MapRenderer(Map map, int x, int y)
        {
            Console.Title = "Map";
            Console.Clear();
            this.DisplayMap(map);
            this.DisplayMenu();
        }

        public void F5(int x, int y, Tile movedObject)
        {
            Console.SetCursorPosition(x, y);
            Console.BackgroundColor = movedObject.TileColor;
            Console.Write(movedObject.TileIcon);
        }

        private void DisplayMap(Map map)
        {
            for (var i = 0; i < map.MapSize; i++)
            {
                for (var j = 0; j < map.MapSize; j++)
                {
                    //Console.ForegroundColor = map.mapArray[i][j].Color;
                    Console.BackgroundColor = map.mapArray[i][j].TileColor;
                    Console.Write(map.mapArray[i][j].TileIcon);
                }
                Console.WriteLine(' ');
            }
        }

        private void DisplayMenu()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Menu \n ");
        }
    }
}
