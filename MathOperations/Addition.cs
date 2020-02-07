using System;

namespace MathOperations
{
    public static class Addition
    {
        static public int Sum(int augEnd, int addEnd)
        {
            var sum = augEnd + addEnd;

            return sum;
        }
        static public decimal Sum(decimal augEnd, decimal addEnd)
        {
            var sum = augEnd + addEnd;

            return sum;
        }

        static public decimal Sum(decimal[] doubleArray)
        {
            decimal result = 0;

            foreach( var x in doubleArray )
            {
                result = Sum(result, x);
            }

            return result;
        }
        static public int Sum(int[] doubleArray)
        {
            int result = 0;

            foreach (var x in doubleArray)
            {
                result = Sum(result, x);
            }

            return result;
        }
    }
}
