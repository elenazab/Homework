using System;


namespace hw7t1
{
    class Program
    {
        static void Main()
        {
            List<int> tmpList = new List<int>();
            tmpList.Add(1);
            tmpList.Add(2);
            tmpList.Add(3);
            foreach(int i in tmpList)
            {
                Console.Write(i);
            }
            Console.Read();
        }
    }
}
