using Microsoft.VisualStudio.TestTools.UnitTesting;
using DynamicArrayDojo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrayDojo.Tests
{
    [TestClass()]
    public class DynamicIntArrayTests
    {
        [TestMethod()]
        public void DynamicIntArrayTest()
        {
            Assert.IsNotNull(new DynamicIntArray());
        }

        [TestMethod()]
        public void DynamicIntArrayTest_WithInitialSize()
        {
            Assert.IsNotNull(new DynamicIntArray(15));
        }

        [TestMethod()]
        public void AddTest()
        {
            DynamicIntArray array = CreateArray(11);
            array.Add(32);
            array.Add(42);
            string result = " 0 1 2 3 4 5 6 7 8 9 10 32 42";
            Assert.AreEqual(result, array.ToString());
        }

        [TestMethod()]
        public void RemoveTest()
        {
            DynamicIntArray array = CreateArray(11);
            array.Remove(5);
            array.Remove(0);
            string result = " 1 2 3 4 6 7 8 9 10";
            Assert.AreEqual(result, array.ToString());
        }

        [TestMethod()]
        public void RemoveTest_LastItem()
        {
            DynamicIntArray array = CreateArray(10);
            array.Remove(9);
            string result = " 0 1 2 3 4 5 6 7 8";
            Assert.AreEqual(result, array.ToString());
        }

        [TestMethod()]
        public void RemoveTest_InvalidItem()
        {
            DynamicIntArray array = CreateArray(10);
            Assert.ThrowsException<IndexOutOfRangeException>(() => array.Remove(10), "");
            Assert.ThrowsException<IndexOutOfRangeException>(() => array.Remove(-1), "");
        }

        [TestMethod()]
        public void InsertTest()
        {
            DynamicIntArray array = CreateArray(11);
            array.Insert(8, 223);
            array.Insert(100, 654);

            string result = " 0 1 2 3 4 5 6 7 223 8 9 10 654";
            Assert.AreEqual(result, array.ToString());
        }

        private DynamicIntArray CreateArray(int numOfElements)
        {
            DynamicIntArray array = new DynamicIntArray();
            for (int i = 0; i < numOfElements; ++i)
            {
                array.Add(i);
            }
            return array;
        }
    }
}