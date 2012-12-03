using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using hw7t1;

namespace UnitTest
{
    [TestClass]
    public class ListTest
    {

        [TestMethod]
        public void TestingAdd()
        {
            List<int> tmpList = new List<int>();
            tmpList.Add(1);
            tmpList.Add(2);
            Assert.IsTrue(tmpList.Del() == 1);
            Assert.IsTrue(tmpList.Del() == 2);
        }

        [ExpectedException(typeof(hw7t1.ListException))]
        [TestMethod]
        public void EmptyListTest()
        {
            List<int> tmpList = new List<int>();
            var t = tmpList.Del();
        }

    }
}
