using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SampleApp.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var expected = 1;
            var actual = 1;

            // Act
            // (Add logic to invoke the method being tested here)

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}