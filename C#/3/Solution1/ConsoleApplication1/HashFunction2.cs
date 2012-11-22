using System;


namespace HashTable
{
    public class HashFunction2 : HashFunction
    {
        public override int Function(string s)
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
