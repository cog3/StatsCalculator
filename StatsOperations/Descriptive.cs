using System;
using MathOperations;

namespace StatsOperations
{
    public class Descriptive
    {
        public static decimal Mean(int[] DataPoints)
        {

            int count = DataPoints.Length;
            int sum = Addition.Sum(DataPoints);
            decimal result = Division.Quotient(sum, count);
            return result;
        }
        public static decimal Mean(decimal[] DataPoints)
        {

            int count = DataPoints.Length;
            decimal sum = Addition.Sum(DataPoints);
            decimal result = Division.Quotient(sum, count);
            return result;
        }
    }
}
