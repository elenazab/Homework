using System;

namespace Map
{
    class GameplayController
    {
        public GameplayController()
        {
            mapSize = 20;
            var testGame = new MapCreator(mapSize);
            playersCoordinateX = rnd.Next(0, mapSize);
            playersCoordinateY = rnd.Next(0, mapSize);
            //test.AddCharacter(PlayersCoordinateX, PlayersCoordinateY);
            var renderer = new MapRenderer(testGame.NewMap, playersCoordinateX, playersCoordinateY);
            var testCharacter = new Character();
            this.Move(testGame, testCharacter);
        }

        private void Move(MapCreator test, Character testCharacter)
        {
            while (!this.GameOver())
            {
                //playersCoordinateX += rnd.Next(-1, 2);
                //playersCoordinateY += rnd.Next(-1, 2);
                if (playersCoordinateX >= 0 && playersCoordinateX < mapSize
                    && playersCoordinateY >= 0 && playersCoordinateY < mapSize
                    && test.NewMap.mapArray[playersCoordinateX][playersCoordinateY].Icon != '~')
                {
                    var tmpTile = test.NewMap.mapArray[playersCoordinateX][playersCoordinateY];
                    test.NewMap.mapArray[playersCoordinateX][playersCoordinateY] = testCharacter;
                    //test.AddCharacter(PlayersCoordinateX, PlayersCoordinateY);
                    var renderer = new MapRenderer(test.NewMap, playersCoordinateX, playersCoordinateY);
                    Console.ReadKey();
                    //Console.Clear();
                    //Console.Write(playersCoordinateX);
                    //Console.ReadKey();
                    test.NewMap.mapArray[playersCoordinateX][playersCoordinateY] = tmpTile;
                }
                playersCoordinateX += rnd.Next(-2, 3);
                playersCoordinateY += rnd.Next(-2, 3);
            }
        }

        private bool GameOver()
        {
            return false;
        }

        private int playersCoordinateX;
        private int playersCoordinateY;
        private Random rnd = new Random();
        private int mapSize;
    }
}
