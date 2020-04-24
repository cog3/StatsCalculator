using System;
using System.Collections.Generic;
using System.Text;

namespace Division
{
    public interface IDivision
    {
        public int Quotient(int Dividend, int Divisor);
        public decimal Quotient(decimal Dividend, decimal Divisor);
    }
}
