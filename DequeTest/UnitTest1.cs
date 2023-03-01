using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DequeInstructions;

namespace DequeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPushMethod()
        {
            MyDeque<int> testDeque = new MyDeque<int>();
            testDeque.Push(1);
            Assert.AreEqual(testDeque.GetArrayValue(0), 1);
        }

        [TestMethod]
        public void TestEnqueueMethod()
        {
            MyDeque<int> testDeque = new MyDeque<int>();
            testDeque.Enqueue(1);
            Assert.AreEqual(testDeque.GetArrayValue(9), 1);
        }

        [TestMethod]
        public void TestPopMethod()
        {
            MyDeque<int> testDeque = new MyDeque<int>();
            testDeque.Push(15);
            testDeque.Push(20);
            int value = testDeque.Pop();
            Assert.AreEqual(value, 20);
        }

        [TestMethod]
        public void TestDequeueMethod()
        {
            MyDeque<int> testDeque = new MyDeque<int>();
            testDeque.Enqueue(15);
            testDeque.Enqueue(20);
            int value = testDeque.Dequeue();
            Assert.AreEqual(value, 15);
        }

        [TestMethod]
        public void TestPeekMethod()
        {
            MyDeque<int> testDeque = new MyDeque<int>();
            testDeque.Push(15);
            testDeque.Push(20);
            int value = testDeque.Peek();
            Assert.AreEqual(value, 20);
        }
    }
}