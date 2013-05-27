using System;


namespace Map
{
    class PlayerDecisionMaker:Behavior
    {
        public PlayerDecisionMaker(MapObject player)
        {
            this.player = player;
        }

        public override Decision Think(Map map)
        {
            if (renderer == null)
            {
                renderer = new MapRenderer(map, player.CoordinateX, player.CoordinateY);
            }
            renderer.DisplayMap(map);
            renderer.DisplayObject(player);
            var key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.LeftArrow:
                    return Decision.WishLeft;
                case ConsoleKey.RightArrow:
                    return Decision.WishRight;
                case ConsoleKey.DownArrow:
                    return Decision.WishDown;
                case ConsoleKey.UpArrow:
                    return Decision.WishUp;
            }
            return Decision.NoWish;
        }

        private MapRenderer renderer;
        private MapObject player;
    }
}