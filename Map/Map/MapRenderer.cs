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
        }

        public void DisplayObject(MapObject movedObject)
        {
            Console.SetCursorPosition(movedObject.CoordinateX, movedObject.CoordinateY);
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write(movedObject.Image);
            Console.SetCursorPosition(movedObject.CoordinateX, movedObject.CoordinateY);
        }

        private void DisplayMap(Map map)
        {
            for (var j = 0; j < map.MapSize; j++)
            {
                for (var i = 0; i < map.MapSize; i++)
                {
                    this.DisplayTile(map, i, j);
                }
                Console.WriteLine(' ');
            }
        }

        public void DisplayTile(Map map, int i, int j)
        {
            Console.SetCursorPosition(i, j);
            Console.BackgroundColor = map.mapArray[i][j].Terrain.Color;
            if (map.mapArray[i][j].listOfObjects.Count == 0)
            {
                Console.Write(map.mapArray[i][j].Terrain.Icon);
            }
            else
            {
                //map.mapArray[i][j].listOfObjects.Find(x => x is StonedCat);
                //тут надо как-то узнать, что из объектов печатать
                Console.Write(map.mapArray[i][j].listOfObjects[0].Image);
            }
        }

        public void DisplayMenu(Map map, string str)
        {
            Console.SetCursorPosition(0, map.MapSize);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(str);
        }
    }
}
