using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace MathOperations.Tests
{
    [TestClass()]
    public class AdditionTests
    {
        [TestMethod()]
        public void SumTest()
        {
            var c = Addition.Sum(1, 2);
            Assert.AreEqual(3, c);
        }
    }
}