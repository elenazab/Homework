using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using hw7t1;

namespace UnitTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void IteratorTest()
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

        [TestMethod]
        public void StackTest()
        {
            Stack<int> mStack = new Stack<int>();
            mStack.Push(1);
            mStack.Push(2);
            mStack.Push(3);
            Assert.IsTrue(mStack.Pop() == 3);
            Assert.IsTrue(mStack.Pop() == 2);
            Assert.IsTrue(mStack.Pop() == 1);
        }

        [ExpectedException(typeof(hw7t1.ListException))]
        [TestMethod]
        public void EmptyStackTest()
        {
            Stack<int> mStack = new Stack<int>();
            var y = mStack.Pop();
        }
    }
}
