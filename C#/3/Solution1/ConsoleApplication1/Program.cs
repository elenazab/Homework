using System;


namespace HashTable
{
    class Program
    {
        static void Main()
        {
            HashFunction ooo = HahsFunction1;
            HashTable myTable = new HashTable(2, ooo);
            //myTable.Add("ololo");
            // myTable.Add("olololo");
            // myTable.PrintTable();
             Console.Read();
        }
    }
}
