using System;

namespace Division
{
    public class Divide : IDivision
    {
        private dynamic Result;
        public int Quotient(int Dividend, int Divisor)
        {
            Result = Quotient(Dividend, Divisor);
            return Result;
        }
        public decimal Quotient(decimal Dividend, decimal Divisor)
        {
            Result = Quotient(Dividend, Divisor);
            return Result;
        }
    }
}
