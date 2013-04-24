using System;

namespace Map
{
    class MapRenderer
    {
        public MapRenderer(Map map, int x, int y)
        {
            Console.Title = "Map";
            Console.Clear();
            this.DisplayMenu("OLOLO");
            this.DisplayMap(map);
        }

        //public void F5(Tile movedObject)
        //{
        //    Console.SetCursorPosition(movedObject.CoordinateX, movedObject.CoordinateY);
        //    Console.BackgroundColor = movedObject.TileColor;
        //    Console.Write(movedObject.TileIcon);
        //}

        private void DisplayMap(Map map)
        {
            for (var j = 0; j < map.MapSize; j++)
            {
                for (var i = 0; i < map.MapSize; i++)
                {
                    //Console.ForegroundColor = map.mapArray[i][j].Color;
                    Console.BackgroundColor = map.mapArray[i][j].Terrain.Color;
                    //Console.Write(map.mapArray[i][j].TileIcon);
                    if (map.mapArray[i][j].listOfObjects.Count == 0)
                    {
                        Console.Write(map.mapArray[i][j].Terrain.Icon);
                    }
                    else
                    {
                        //тут надо как-то узнать, что из объектов печатать
                        Console.Write(map.mapArray[i][j].listOfObjects[0].Image);
                    }
                }
                Console.WriteLine(' ');
            }
        }

        private void DisplayMenu(string str)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(str);
        }
    }
}
