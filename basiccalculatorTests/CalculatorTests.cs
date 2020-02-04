using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace basiccalculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        private Calculator Calculator = new Calculator();
        private readonly int aInt = 1;
        private readonly int bInt = 2;
        private readonly double aDouble = 1.5;
        private readonly double bDouble = 2.5;

        [TestInitialize()]
        public void Setup()
        {

        }

        [TestMethod()]
        public void AddIntegerTest()
        {
            Calculator.Sum(aInt, bInt);
            Assert.AreEqual(3, Calculator.Result);
        }
        public void AddDoubleTest()
        {
            Calculator.Sum(aDouble, bDouble);
            Assert.AreEqual(4, Calculator.Result);
        }


        [TestMethod()]
        public void SubtractTest()
        {
            Calculator.Subtract(aInt, bInt);
            Assert.AreEqual(-1, Calculator.Result);
        }
    }
}