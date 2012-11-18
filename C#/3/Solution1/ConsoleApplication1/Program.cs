using System;

namespace HashTable
{
    class Program
    {
        static void Main()
        {
             HashTable myTable = new HashTable(2);
             myTable.Add("ololo");
             myTable.Add("olololo");
             myTable.PrintTable();
             Console.Read();
        }
    }
}
