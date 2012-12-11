using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using hw5t1;

namespace UnitTests
{
    [TestClass]
    public class DivTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Division testDiv = new Division();
            testDiv.Right = new Operand(1);
            testDiv.Left = new Operand(6);
            Assert.IsTrue(testDiv.Calculate() == 6);
        }
    }
}
