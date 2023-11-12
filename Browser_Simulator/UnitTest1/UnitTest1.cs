using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Browser_Simulator
{
    [TestClass]
    public class StringStackTests
    {
        [TestMethod]
        public void Push_Pop_Test()
        {
            // Arrange
            StringStack stack = new StringStack(5);

            // Act
            stack.Push("Test");
            string poppedValue = stack.Pop();

            // Assert
            Assert.AreEqual("Test", poppedValue);
            Assert.IsTrue(stack.IsEmpty);
        }

        [TestMethod]
        public void Peek_Test()
        {
            // Arrange
            StringStack stack = new StringStack(5);

            // Act
            stack.Push("Test");
            string peekedValue = stack.Peek();

            // Assert
            Assert.AreEqual("Test", peekedValue);
            Assert.IsFalse(stack.IsEmpty);
        }

        [TestMethod]
        public void Swap_Test()
        {
            // Arrange
            StringStack stack = new StringStack(3);

            // Act
            stack.Push("A");
            stack.Push("B");
            stack.Push("C");
            stack.Swap();

            // Assert
            Assert.AreEqual("A", stack.Pop());
            Assert.AreEqual("C", stack.Pop());
            Assert.AreEqual("B", stack.Pop());
            Assert.IsTrue(stack.IsEmpty);
        }

        [TestMethod]
        public void Clear_Test()
        {
            // Arrange
            StringStack stack = new StringStack(3);

            // Act
            stack.Push("A");
            stack.Push("B");
            stack.Push("C");
            stack.Clear();

            // Assert
            Assert.IsTrue(stack.IsEmpty);
        }

        [TestMethod]
        public void IsEmpty_Test()
        {
            // Arrange
            StringStack stack = new StringStack(5);

            // Act & Assert
            Assert.IsTrue(stack.IsEmpty);

            // Push an item and check again
            stack.Push("Test");
            Assert.IsFalse(stack.IsEmpty);
        }

        [TestMethod]
        public void Count_Test()
        {
            // Arrange
            StringStack stack = new StringStack(5);

            // Act & Assert
            Assert.AreEqual(0, stack.Count);

            // Push items and check count
            stack.Push("Test1");
            stack.Push("Test2");
            Assert.AreEqual(2, stack.Count);

            // Pop an item and check count
            stack.Pop();
            Assert.AreEqual(1, stack.Count);
        }

        [TestMethod]
        public void IsFull_Test()
        {
            // Arrange
            StringStack stack = new StringStack(2);

            // Act & Assert
            Assert.IsFalse(stack.IsFull);

            // Push items to make it full and check
            stack.Push("Test1");
            stack.Push("Test2");
            Assert.IsTrue(stack.IsFull);
        }

        [TestMethod]
        public void ToString_Test()
        {
            // Arrange
            StringStack stack = new StringStack(3);

            // Act & Assert
            Assert.AreEqual("", stack.ToString());

            // Push items and check ToString result
            stack.Push("A");
            stack.Push("B");
            stack.Push("C");
            Assert.AreEqual("A, B, C", stack.ToString());
        }
    }
}