using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Datastructures;

namespace DatastructuresTest
{
    [TestClass]
    public class MyArrayListTest
    {
        MyArrayList<object> list = new MyArrayList<object>();

        public MyArrayListTest()
        {
            list.add(1);
            list.add(2);
            list.add("TEST");
            list.add(3);
            list.add(4);
        }

        [TestMethod]
        public void ArrayListGet()
        {
            Assert.AreEqual(list.get(3),"TEST");
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void ArrayListGetOutOfBoundsOver()
        {
            list.get(7);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void ArrayListGetOutOfBoundsUnder()
        {
            list.get(-7);
        }

        [TestMethod]
        public void ArrayListRemove()
        {
            list.remove(3);
            Assert.AreEqual(list.get(3), 3);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void ArrayListRemoveOutOfBoundsOver()
        {
            list.remove(7);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void ArrayListRemoveOutOfBoundsUnder()
        {
            list.remove(-7);
        }
    }
}
