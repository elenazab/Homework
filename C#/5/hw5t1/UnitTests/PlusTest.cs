using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using hw5t1;

namespace UnitTests
{
    [TestClass]
    public class PlusTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Plus testPlus = new Plus();
            testPlus.Right = new Operand(1);
            testPlus.Left = new Operand(2);
            Assert.IsTrue(testPlus.Calculate() == 3);
        }
    }
}
