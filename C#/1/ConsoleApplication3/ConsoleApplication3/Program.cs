using System;

namespace ConsoleApplication3
{
    class Program
    {
        static void Swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }

        static void BubbleSort(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
                for(int j = 0; j < n - 1; j++)
                    if(a[j] > a[j + 1])
                        Swap(ref a[j], ref a[j + 1]);
        }

        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            var myArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                myArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            BubbleSort(myArray, n);
            for (int i = 0; i < n; i++)
            {
                Console.Write(myArray[i]);
            }
            Console.Read();
        }
    }
}
