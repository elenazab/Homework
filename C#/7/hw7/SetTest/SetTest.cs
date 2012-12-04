using Microsoft.VisualStudio.TestTools.UnitTesting;
using hw7t2;

namespace SetTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestAdd()
        {
            var mySet = new Set<int>();
            Assert.IsTrue(!mySet.IsExist(1));
            mySet.Add(1);
            Assert.IsTrue(mySet.IsExist(1));
        }

        [TestMethod]
        public void TestExist()
        {
            var mySet = new Set<int>();
            mySet.Add(1);
            Assert.IsTrue(mySet.IsExist(1));
        }

        [TestMethod]
        public void TestDel()
        {
            var mySet = new Set<int>();
            mySet.Add(1);
            mySet.Add(2);
            mySet.Del(2);
            Assert.IsTrue(mySet.IsExist(1));
            Assert.IsTrue(!mySet.IsExist(2));
        }

        [TestMethod]
        public void TestUnion()
        {
            var mySet1 = new Set<int>();
            mySet1.Add(1);
            mySet1.Add(2);
            var mySet2 = new Set<int>();
            mySet2.Add(3);
            mySet1.UnionOfSets(mySet2);
            Assert.IsTrue(mySet1.IsExist(1) && mySet1.IsExist(2) && mySet1.IsExist(3));
        }

        [TestMethod]
        public void TestIntersect()
        {
            var mySet1 = new Set<int>();
            mySet1.Add(1);
            mySet1.Add(2);
            var mySet2 = new Set<int>();
            mySet2.Add(2);
            mySet2.Add(3);
            var mySet3 = new Set<int>();
            mySet3 = mySet1.IntersectionsOfSets(mySet2);
            Assert.IsTrue(!mySet3.IsExist(1) && mySet3.IsExist(2) && !mySet3.IsExist(3));
        }
    }
}
