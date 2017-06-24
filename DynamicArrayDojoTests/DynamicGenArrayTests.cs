using Microsoft.VisualStudio.TestTools.UnitTesting;
using DynamicArray;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray.Tests
{
    [TestClass()]
    public class DynamicGenArrayTests
    {
        [TestMethod()]
        public void DynamicGenArrayTest()
        {
            Assert.IsNotNull(new DynamicGenArray<int>());
            Assert.IsNotNull(new DynamicGenArray<string>());
        }

        [TestMethod()]
        public void DynamicGenArrayTest_WithInitialSize()
        {
            Assert.IsNotNull(new DynamicGenArray<int>(15));
            Assert.IsNotNull(new DynamicGenArray<string>(15));
        }

        [TestMethod()]
        public void AddTest_Int()
        {
            DynamicGenArray<int> array = CreateArrayInt(11);
            array.Add(32);
            array.Add(42);
            string result = " 0 1 2 3 4 5 6 7 8 9 10 32 42";
            Assert.AreEqual(result, array.ToString());
        }

        [TestMethod()]
        public void AddTest_String()
        {
            DynamicGenArray<string> array = CreateArrayString(11);
            array.Add(32.ToString());
            array.Add(42.ToString());
            string result = " 0 1 2 3 4 5 6 7 8 9 10 32 42";
            Assert.AreEqual(result, array.ToString());
        }

        [TestMethod()]
        public void RemoveTest_Int()
        {
            DynamicGenArray<int> array = CreateArrayInt(11);
            array.Remove(5);
            array.Remove(0);
            string result = " 1 2 3 4 6 7 8 9 10";
            Assert.AreEqual(result, array.ToString());
        }

        [TestMethod()]
        public void RemoveTest_String()
        {
            DynamicGenArray<string> array = CreateArrayString(11);
            array.Remove(5);
            array.Remove(0);
            string result = " 1 2 3 4 6 7 8 9 10";
            Assert.AreEqual(result, array.ToString());
        }

        [TestMethod()]
        public void RemoveTest_LastItem_Int()
        {
            DynamicGenArray<int> array = CreateArrayInt(10);
            array.Remove(9);
            string result = " 0 1 2 3 4 5 6 7 8";
            Assert.AreEqual(result, array.ToString());
        }

        [TestMethod()]
        public void RemoveTest_LastItem_String()
        {
            DynamicGenArray<string> array = CreateArrayString(10);
            array.Remove(9);
            string result = " 0 1 2 3 4 5 6 7 8";
            Assert.AreEqual(result, array.ToString());
        }

        [TestMethod()]
        public void RemoveTest_InvalidItem_Int()
        {
            DynamicGenArray<int> array = CreateArrayInt(10);
            Assert.ThrowsException<IndexOutOfRangeException>(() => array.Remove(10), "");
            Assert.ThrowsException<IndexOutOfRangeException>(() => array.Remove(-1), "");
        }

        [TestMethod()]
        public void RemoveTest_InvalidItem_String()
        {
            DynamicGenArray<string> array = CreateArrayString(10);
            Assert.ThrowsException<IndexOutOfRangeException>(() => array.Remove(10), "");
            Assert.ThrowsException<IndexOutOfRangeException>(() => array.Remove(-1), "");
        }

        [TestMethod()]
        public void InsertTest_Int()
        {
            DynamicGenArray<int> array = CreateArrayInt(11);
            array.Insert(8, 223);
            array.Insert(100, 654);

            string result = " 0 1 2 3 4 5 6 7 223 8 9 10 654";
            Assert.AreEqual(result, array.ToString());
        }

        [TestMethod()]
        public void InsertTest_String()
        {
            DynamicGenArray<string> array = CreateArrayString(11);
            array.Insert(8, 223.ToString());
            array.Insert(100, 654.ToString());

            string result = " 0 1 2 3 4 5 6 7 223 8 9 10 654";
            Assert.AreEqual(result, array.ToString());
        }

        private DynamicGenArray<int> CreateArrayInt(int numOfElements)
        {
            DynamicGenArray<int> array = new DynamicGenArray<int>();
            for (int i = 0; i < numOfElements; ++i)
            {
                array.Add(i);
            }
            return array;
        }

        private DynamicGenArray<string> CreateArrayString(int numOfElements)
        {
            DynamicGenArray<string> array = new DynamicGenArray<string>();
            for (int i = 0; i < numOfElements; ++i)
            {
                array.Add(i.ToString());
            }
            return array;
        }
    }
}