using System;
using Addition;
using Subtraction;
using Division;
using Multiplication;

namespace basiccalculator
{
    public class Calculator : IAdd, ISubtract, IDivision, IMultiply
    {

        public dynamic Result
        {
            get => _result;
            set => _result = value;
        }

        Adding Addition = new Adding();
        Difference Subtraction = new Difference();
        Divide Division = new Divide();
        Multiply Multiplication = new Multiply();
        private dynamic _result;

        public dynamic Sum(dynamic a, dynamic b)
        {
            Result = Addition.Sum(a, b);
            return Result;

        }
        public dynamic Sum(dynamic arrayList)
        {
            Result = Addition.Sum(arrayList);
            return Result;
        }

        public int Subtract(int a, int b)
        {
            Result = Subtraction.Subtract(a, b);
            return Result;

        }
        public int Quotient(int Dividend, int Divisor)
        {
            Result = Division.Quotient(Dividend, Divisor);
            return Result;
        }
        public decimal Quotient(decimal Dividend, decimal Divisor)
        {
            Result = Division.Quotient(Dividend, Divisor);
            return Result;
        }
        public int Product(int a, int b)
        {
            Result = Multiplication.Product(a, b);
            return Result;
        }
        public decimal Product(decimal a, decimal b)
        {
            Result = Multiplication.Product(a, b);
            return Result;
        }

    }
}
