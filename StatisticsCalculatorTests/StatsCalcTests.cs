using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatisticsCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatisticsCalculator.Tests
{
    [TestClass()]
    public class StatsCalcTests
    {
        [TestMethod()]
        public void MeanTest()
        {
            decimal[] DataPoints = { 1M, 2M };
            StatsCalc statsCalc = new StatsCalc();
            var result = statsCalc.Mean(DataPoints);
            Assert.AreEqual(1.5M, result);
        }
    }
}