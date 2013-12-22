using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using hw1t2;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            int n = 3;
            int[,] array = {{1, 0, 1}, {0, 1, 0}, {1, 0, 1}};
            Random testRnd = new Random(1);
            Network testNetwork = new Network(n, array, testRnd);
            Random testRnd2 = new Random(1);
            for (int i = 0; i < n; i++)
            {
                if (testRnd2.Next(0, 2) < 1)
                {
                    Assert.IsTrue((testRnd2.Next(0, 100) > 65) == (testNetwork.getVirus(i)));
                }
                else
                {
                    Assert.IsTrue((testRnd2.Next(0, 100) > 55) == (testNetwork.getVirus(i)));
                }
            }
        }
    }
}
