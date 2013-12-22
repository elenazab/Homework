using System;


namespace _3._2._2
{
    public class Program
    {
        /// <summary>
        /// подсчет ненулевых элементов массива
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int Sum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                if (array[i] == 0)
                    sum++;
            }
            return sum;
        }

        static void Main()
        {
            Random rnd = new Random();
            int[] array = new int[10];
            for (int i = 0; i < 10; i++)
                array[i] = rnd.Next(-5, 5);
            int sum = Sum(array);
            Console.WriteLine(sum);
            Console.Read();
        }
    }
}

