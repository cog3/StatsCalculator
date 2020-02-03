using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace basiccalculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        private Calculator Calculator = new Calculator();
        private readonly int aInt = 1;
        private readonly int bInt = 2;


        [TestInitialize()]
        public void Setup()
        {

        }

        [TestMethod()]
        public void AddTest()
        {
            Calculator.Add(aInt, bInt);
            Assert.AreEqual(3, Calculator.Result);
        }

        [TestMethod()]
        public void SubtractTest()
        {
            Calculator.Subtract(aInt, bInt);
            Assert.AreEqual(-1, Calculator.Result);
        }
    }
}