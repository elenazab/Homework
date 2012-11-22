using System;
using System.Collections.Generic;

namespace HashTable
{
    class HashTable
    {
        public HashTable(int n, HashFunction f)
        {
            this.n = n;
            table = new LinkedList<string>[n];
            for (int i = 0; i < n; i++)
                table[i] = new LinkedList<string>();
            this.Function = f;
        }

        public void Add(string s)
        {
            int tmp = Function.Function(s) % n;
            table[tmp].AddFirst(s);
        }

        public void Del(string s)
        {
            int tmp = Function.Function(s) % n;
            if (table[tmp].Contains(s))
                table[tmp].Remove(s);
            else
                Console.WriteLine("not found");
        }

        public void PrintTable()
        {
            for (int i = 0; i < n; i++)
            {
                foreach (string t in table[i])
                    Console.WriteLine(t);
            }
        }

        public bool IsExist(string s)
        {
            int tmp = Function.Function(s) % n;
            return table[tmp].Contains(s);
        }

        private int n;
        private LinkedList<string>[] table;
        private HashFunction Function;
    }
}
