using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Homework8;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DequeueTest()
        {
            var testQueue = new PriorityQueue<int>();
            testQueue.Enqueue(6, 1);
            testQueue.Enqueue(10, 0);
            testQueue.Enqueue(5, 0);
            Assert.IsTrue(testQueue.Dequeue() == 6);
            Assert.IsTrue(testQueue.Dequeue() == 5);
            Assert.IsTrue(testQueue.Dequeue() == 10);
        }

        [ExpectedException(typeof(Homework8.QueueException))]
        [TestMethod]
        public void ExceptionTest()
        {
            var testQueue = new PriorityQueue<int>();
            testQueue.Dequeue();
        }
    }
}
