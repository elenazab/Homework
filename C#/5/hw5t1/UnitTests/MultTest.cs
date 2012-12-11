using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using hw5t1;

namespace UnitTests
{
    [TestClass]
    public class MultTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Multiplication testMult = new Multiplication();
            testMult.Right = new Operand(4);
            testMult.Left = new Operand(2);
            Assert.IsTrue(testMult.Calculate() == 8);
        }
    }
}
