using System;

namespace ConsoleApplication3
{
    class Program
    {
        static void swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }

        static void bubbleSort(ref int[] a, int n)
        {
            for (int i = 0; i < n; i++)
                for(int j = 0; j < n - 1; j++)
                    if(a[j] > a[j+1])
                        swap(ref a[j], ref a[j+1]);
        }

        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] myArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                myArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            bubbleSort(ref myArray, n);
            for (int i = 0; i < n; i++)
            {
                Console.Write(myArray[i]);
            }
            Console.Read();
        }
    }
}
