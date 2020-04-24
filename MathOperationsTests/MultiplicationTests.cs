using System;
using System.Collections.Generic;
using System.Text;
using MathOperations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathOperations.Tests
{
    [TestClass()]
    public class MultiplicationTests
    {
        [TestMethod()]
        public void ProductTest()
        {
            int result = Multiplication.Product(5, 5);
            Assert.AreEqual(25, result);
        }
        [TestMethod()]
        public void ProductTestDecimal()
        {
            decimal result = Multiplication.Product(3.5m, 2);
            Assert.AreEqual(7.0, result);
        }
    }
}
