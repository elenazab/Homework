using System;

namespace Map
{
    class GameplayController
    {
        public GameplayController()
        {
            mapSize = 20;
            var testGame = new MapAutoCreator(mapSize);
            playersCoordinateX = rnd.Next(0, mapSize);
            playersCoordinateY = rnd.Next(0, mapSize);
            var renderer = new MapRenderer(testGame.NewMap, playersCoordinateX, playersCoordinateY);
            var testCharacter = new Character();
            this.Move(testGame, testCharacter);
        }

        /// <summary>
        /// ololo
        /// </summary>
        /// <param name="test"></param>
        /// <param name="testCharacter"></param>
        private void Move(MapAutoCreator test, Character testCharacter)
        {

            var tmpTile0 = test.NewMap.mapArray[playersCoordinateX][playersCoordinateY];
            test.NewMap.mapArray[playersCoordinateX][playersCoordinateY] = testCharacter;
            var renderer0 = new MapRenderer(test.NewMap, playersCoordinateX, playersCoordinateY);
            test.NewMap.mapArray[playersCoordinateX][playersCoordinateY] = tmpTile0;

            while (!this.GameOver())
            {
                if (playersCoordinateX >= 0 && playersCoordinateX < mapSize
                    && playersCoordinateY >= 0 && playersCoordinateY < mapSize
                    && test.NewMap.mapArray[playersCoordinateX][playersCoordinateY].TileIcon != '~')
                {
                    var tmpTile = test.NewMap.mapArray[playersCoordinateX][playersCoordinateY];
                    test.NewMap.mapArray[playersCoordinateX][playersCoordinateY] = testCharacter;
                    renderer0.F5(playersCoordinateX, playersCoordinateY, testCharacter);
                    //var renderer = new MapRenderer(test.NewMap, playersCoordinateX, playersCoordinateY);
                    Console.ReadKey(true);
                    renderer0.F5(playersCoordinateX, playersCoordinateY, tmpTile);
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
        private Random rnd = SingletonRandom.Instance();
        private int mapSize;
    }
}
