using System;
using MathOperations;

namespace Division
{
    class Division : IDivision
    {
        private dynamic Result;

        public int Quotient(int Dividend, int Divisor)
        {
            Result = MathOperations.Division.Quotient(Dividend, Divisor);
            return Result;
        }
        public decimal Quotient(decimal Dividend, decimal Divisor)
        {
            Result = MathOperations.Division.Quotient(Division, Divisor);
            return Result;
        }
    }
}
