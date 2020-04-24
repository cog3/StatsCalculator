﻿using basiccalculator;
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
        public void Setup(){}
        [TestMethod()]
        public void AddIntegerTest()
        {
            Calculator.Sum(aInt, bInt);
            Assert.AreEqual(3, Calculator.Result);
        }
        [TestMethod()]
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

        [TestMethod()]
        public void SumIntTest()
        {
            int[] arrayList = {1, 2, 3 };
            Calculator.Sum(arrayList);
            Assert.AreEqual(6, Calculator.Result);
        }

        [TestMethod()]
        public void SumDoubleTest()
        {
            decimal[] arrayList = { 1.1M, 2.1M, 3.1M };
            Calculator.Sum(arrayList);
            Assert.AreEqual(6.3M, Calculator.Result);
        }
        [TestMethod()]
        public void QuotientIntTest()
        {
            int result = Calculator.Quotient(25, 5);
            Assert.AreEqual(5, result);
        }
        [TestMethod()]
        public void QuotientDecimalTest()
        {
            decimal result = Calculator.Quotient(7.7m, 2.5m);
            Assert.AreEqual(3.08m, result);
        }
        [TestMethod()]
        public void ProductIntTest()
        {
            int product = Calculator.Product(40, 2);
            Assert.AreEqual(80, product);
        }
        [TestMethod()]
        public void ProductDecimalTest()
        {
            decimal product = Calculator.Product(3.5m, 2.0m);
            Assert.AreEqual(7.0m, product);
        }
    }
}