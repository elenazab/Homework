using System;


namespace HashTable
{
    public delegate int HashFunction(string s);

    public class Functions
    {
        public static int HahsFunction1(string s)
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
        public static int HahsFunction2(string s)
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
    }
}
