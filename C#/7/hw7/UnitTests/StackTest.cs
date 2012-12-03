using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using hw7t1;

namespace UnitTest
{
    [TestClass]
    public class StackTest
    {
        [TestMethod]
        public void PushTest()
        {
            Stack<int> mStack = new Stack<int>();
            mStack.Push(1);
            mStack.Push(2);
            mStack.Push(3);
            Assert.IsTrue(mStack.Pop() == 3);
            Assert.IsTrue(mStack.Pop() == 2);
            Assert.IsTrue(mStack.Pop() == 1);
        }

        [ExpectedException(typeof(hw7t1.StackException))]
        [TestMethod]
        public void EmptyStackTest()
        {
            Stack<int> mStack = new Stack<int>();
            var y = mStack.Pop();
        }
    }
}
