using System;

namespace HashTable
{
    class Program
    {
        static void Main()
        {
             var myTable = new HashTable(2);
             myTable.Add("ololo");
             myTable.Add("olololo");
             myTable.PrintTable();
             Console.Read();
        }
    }
}
