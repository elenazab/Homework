using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using hw321;

namespace UnitTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Test1()
        {
            int[,] array = {{1, 1, 0}, {1, 1, 1}, {0, 1, 1}};
            bool[] robArray = {true, false, true};
            RobotsSolver test = new RobotsSolver(array, robArray);
            Assert.IsTrue(test.IsPossible());
        }

        [TestMethod]
        public void Test2()
        {
            int[,] array = { { 1, 1, 0 }, { 1, 1, 1 }, { 0, 1, 1 } };
            bool[] robArray = { false, true, false };
            RobotsSolver test = new RobotsSolver(array, robArray);
            Assert.IsFalse(test.IsPossible());
        }

        [TestMethod]
        public void Test3()
        {
            int[,] array = { { 1, 1, 0, 0 }, { 1, 1, 1, 0 }, { 0, 1, 1, 1 }, { 0, 0, 1, 1 } };
            bool[] robArray = { true, true, true, false };
            RobotsSolver test = new RobotsSolver(array, robArray);
            Assert.IsFalse(test.IsPossible());
        }

        [TestMethod]
        public void Test4()
        {
            int[,] array = { { 1, 1, 0, 0 }, { 1, 1, 1, 0 }, { 0, 1, 1, 1 }, { 0, 0, 1, 1 } };
            bool[] robArray = { true, false, true, false };
            RobotsSolver test = new RobotsSolver(array, robArray);
            Assert.IsTrue(test.IsPossible());
        }

        [TestMethod]
        public void Test5()
        {
            int[,] array = { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
            bool[] robArray = { false, true, true };
            RobotsSolver test = new RobotsSolver(array, robArray);
            Assert.IsTrue(test.IsPossible());
        }
    }
}
