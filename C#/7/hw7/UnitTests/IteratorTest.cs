using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using hw7t1;

namespace UnitTest
{
    [TestClass]
    public class IteratorTest
    {
        [TestMethod]
        public void Test()
        {
            List<int> tmpList = new List<int>();
            tmpList.Add(1);
            tmpList.Add(2);
            tmpList.Add(3);
            var tmp = 1;
            foreach (int i in tmpList)
            {
                Assert.IsTrue(tmp == i);
                tmp++;
            }
        }
    }
}
