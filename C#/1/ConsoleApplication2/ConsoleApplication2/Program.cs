using System;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int fibonacciNumber1 = 1;
            int fibonacciNumber2 = 1;
            int fibonacciNumber3 = 0;
            for (int i = 3; i <= n; i++)
            {
                fibonacciNumber3 = fibonacciNumber1 + fibonacciNumber2;
                fibonacciNumber1 = fibonacciNumber2;
                fibonacciNumber2 = fibonacciNumber3;
            }
            Console.WriteLine(fibonacciNumber3);
            Console.Read();
        }
    }
}
