using System;

namespace MathOperations
{
    public static class Division
    {
        static public decimal Quotient(int Dividend, int Divisisor)
        {
            var quotient = Dividend / Divisisor;

            return quotient;
        }
        static public decimal Quotient(decimal Dividend, decimal Divisisor)
        {
            var quotiont = Dividend / Divisisor;

            return quotiont;
        }
    }
}
