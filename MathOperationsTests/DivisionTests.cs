using System;
using System.Collections.Generic;
using System.Text;
using MathOperations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathOperations.Tests
{
    [TestClass()]
    public class DivisionTests
    {
        [TestMethod()]
        public void QuotientTest()
        {
            var result = Division.Quotient(20, 5);
            Assert.AreEqual(4, result);
        }
    }
}
