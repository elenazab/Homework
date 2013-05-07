using System;

namespace Map
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new GameplayController();
            test.StartGame();
            Console.ReadKey();
        }
    }
}
