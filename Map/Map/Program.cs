using System;

namespace Map
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new MapCreator(60);
            var renderer = new MapRenderer(test.NewMap);
            Console.ReadKey();
        }
    }
}
