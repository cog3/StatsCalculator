using System;
using MathOperations;

namespace basiccalculator
{
    public class Calculator
    {
        private int _result;

        public int Result {
            get => _result;
            set => _result = value;
        }
        public int Add(int a, int b)
        {
            Result = Addition.Sum(a, b);
            return Result;
        }
        public int Subtract(int a, int b)
        {
            Result = Subtraction.Result(a, b);
            return Result;

        }

    }
}
