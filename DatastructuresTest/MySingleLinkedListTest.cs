using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Datastructures;

namespace DatastructuresTest
{
    [TestClass]
    public class MySingleLinkedListTest
    {
        MySingleLinkedList<int> ll = new MySingleLinkedList<int>();

        public MySingleLinkedListTest()
        {
            ll.add(1);
            ll.add(2);
            ll.add(3);
            ll.add(4);
            ll.add(5);
        }

        [TestMethod]
        public void SingleLinkedListGet()
        {
            Assert.AreEqual(ll.get(2), 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SingleLinkedListGetRangeOver()
        {
            ll.get(6);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SingleLinkedListGetRangeUnder()
        {
            ll.get(0);
        }

        [TestMethod]
        public void SingleLinkedListDelete()
        {
            ll.delete(2);
            Assert.AreEqual(ll.get(2), 3);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SingleLinkedListDeleteRangeOver()
        {
            ll.delete(6);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SingleLinkedListDeleteRangeUnder()
        {
            ll.delete(0);
        }
        
    }
}
