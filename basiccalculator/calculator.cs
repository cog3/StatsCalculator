using System;
using MathOperations;
using Addition;
using Subtraction;

namespace basiccalculator
{
    public class Calculator : IAdd, ISubtract
    {
        private dynamic _result;

        public dynamic Result
        {
            get => _result;
            set => _result = value;
        }

        Adding Addition = new Adding();
        Difference Subtraction = new Difference();

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

    }
}
