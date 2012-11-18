using System;
using System.Collections.Generic;


namespace HashTable
{
    class HashTable
    {
        public HashTable(int n)
        {
            this.n = n;
            table = new LinkedList<string>[n];
            for (int i = 0; i < n; i++)
                table[i] = new LinkedList<string>();
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
                foreach(string t in table[i])
                    Console.WriteLine(t);
            }
        }

        public bool IsExist(string s)
        {
            int tmp = Function(s) % n;
            if (table[tmp].Contains(s))
                return true;
            return false;
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

        private int n;
        private LinkedList<string>[] table;
    }
}
