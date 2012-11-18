using System;
using System.Collections.Generic;


namespace HashTable
{
    class HashTable
    {
        private int n;
        private LinkedList<string>[] table;

        public HashTable(int N)
        {
            n = N;
            table = new LinkedList<string>[n];
            for (int i = 0; i < n; i++)
                table[i] = new LinkedList<string>();
        }

        private int Function(string s)
        {
            int result = 0;
            int i = 0;
            while (i < s.Length - 1)
            {
                result += s[i];
                i++;
            }
            return result;
        }

        public void Add(string s)
        {
            int tmp = Function(s) % n;
            table[tmp].AddFirst(s);
        }

        public void Del(string s)
        {
            int tmp = Function(s) % n;
            if (table[tmp].Contains(s))
                table[tmp].Remove(s);
            else
                Console.WriteLine("not found");
        }

        public void PrintTable()
        {
            for (int i = 0; i < n; i++)
            {
                while (table[i].First != null)
                {
                    Console.WriteLine(table[i].First.Value);
                    table[i].RemoveFirst();
                }
            }
        }
    }
}
