using System;
using MathOperations;

namespace basiccalculator
{
    public class Calculator
    {
        private int _result;

        public dynamic Result {
            get => _result;
            set => _result = value;
        }
 
        public dynamic Sum(dynamic a, dynamic b)
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
