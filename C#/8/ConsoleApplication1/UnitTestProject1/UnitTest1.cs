using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DequeueTest()
        {
            var testQueue = new PriorityQueue<int>();
            testQueue.Enqueue(5, 1);
            testQueue.Enqueue(10, 0);
            testQueue.Enqueue(5, 0);
            Assert.IsTrue(testQueue.Dequeue() == 5);
            Assert.IsTrue(testQueue.Dequeue() == 5);
            Assert.IsTrue(testQueue.Dequeue() == 10);
        }

        [ExpectedException(typeof(ConsoleApplication1.QueueException))]
        [TestMethod]
        public void ExceptionTest()
        {
            var testQueue = new PriorityQueue<int>();
            testQueue.Dequeue();
        }
    }
}
