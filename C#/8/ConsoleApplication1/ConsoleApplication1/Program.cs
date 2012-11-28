using System;


namespace Homework8
{
    class Program
    {
        static void Main()
        {
            var intQueue = new PriorityQueue<int>();
            intQueue.Enqueue(5, 1);
            intQueue.Enqueue(10, 0);
            intQueue.Enqueue(5, 0);
            while (true)
            {
                var val = 0;
                try
                {
                    val = intQueue.Dequeue();
                }
                catch (QueueException)
                {
                    break;
                }
                Console.WriteLine(val);
            }
            Console.Read();
        }
    }
}
