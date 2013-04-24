using System;


namespace Map
{
    class PlayerDecisionMaker:Behavior
    {
        public override Decision Think()
        {
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
    }
}