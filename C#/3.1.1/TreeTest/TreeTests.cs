using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using hw311;

namespace TreeTest
{
    [TestClass]
    public class TreeTests
    {
        [TestMethod]
        public void Add()
        {
            Tree testTree = new Tree();
            Assert.IsFalse(testTree.IsExists(1));
            testTree.Add(1);
            Assert.IsTrue(testTree.IsExists(1));
        }

        [TestMethod]
        public void Del()
        {
            Tree testTree = new Tree();
            testTree.Add(1);
            testTree.Add(2);
            testTree.Add(3);
            testTree.Delete(2);
            Assert.IsTrue(testTree.IsExists(1));
            Assert.IsFalse(testTree.IsExists(2));
            Assert.IsTrue(testTree.IsExists(3));
        }
    }
}
