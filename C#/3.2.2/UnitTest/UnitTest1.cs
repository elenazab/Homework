using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _3._2._2;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSum()
        {
            int[] array1 = {1, 1, 0, 2, 1, 6, 7, 0, 0, 0};
            Assert.IsTrue(Program.Sum(array1) == 4);
            int[] array2 = { 1, 1, 5, 2, 1, 6, 7, 4, 3, 2 };
            Assert.IsTrue(Program.Sum(array2) == 0);
            int[] array3 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            Assert.IsTrue(Program.Sum(array3) == 10);
        }
    }
}
