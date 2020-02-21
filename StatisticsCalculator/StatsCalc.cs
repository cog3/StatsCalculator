using System;
using basiccalculator;
using StatsOperations;

namespace StatisticsCalculator
{
    public class StatsCalc: Calculator
    {
        public decimal Mean(dynamic DataPoints)
        {
            var Result = Descriptive.Mean(DataPoints);
            return Result;
        }
    }
}
