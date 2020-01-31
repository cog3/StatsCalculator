using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace MathOperations.Tests
{
    [TestClass()]
    public class SubtractionTests
    {
        [TestMethod()]
        public void ResultTest()
        {
            var c = Subtraction.Result(1, 2);
            Assert.AreEqual(-1, c);
        }
    }
}