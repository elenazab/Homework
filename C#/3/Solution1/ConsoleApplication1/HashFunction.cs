using System;


//namespace HashTable
//{
//     abstract public class HashFunction
//    {
//        abstract public int Function(string s);
//    }
//}

namespace HashTable
{
    public delegate int HashFunction(string s);

    public class Functions
    {
        public int HahsFunction1(string s)
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
        public int HahsFunction2(string s)
        {
            int result = 0;
            int i = 0;
            while (i < s.Length - 1)
            {
                result += s[i] * s[i];
                i++;
            }
            return result;
        }

        //void test()
        //{
        //    HashFunction ooo = HahsFunction1;
        //    HashTable myTable = new HashTable(2, ooo);
        //}
    }
}
