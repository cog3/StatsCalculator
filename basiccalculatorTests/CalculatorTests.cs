using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace basiccalculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            var _Calculator = new Calculator();
            _Calculator.Add(1, 2);
            Assert.AreEqual(3, _Calculator.Result);
        }

        [TestMethod()]
        public void SubtractTest()
        {
            var _Calculator = new Calculator();
            _Calculator.Subtract(1, 2);
            Assert.AreEqual(-1, _Calculator.Result);
        }
    }
}