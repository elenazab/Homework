using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using hw5t1;

namespace UnitTests
{
    [TestClass]
    public class MinusTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Minus testMinus = new Minus();
            testMinus.Right = new Operand(3);
            testMinus.Left = new Operand(5);
            Assert.IsTrue(testMinus.Calculate() == 2);
        }
    }
}
