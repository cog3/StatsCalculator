using System;
using MathOperations;
namespace Subtraction
{

    public class Difference
    {
        private dynamic Result;

        public int Subtract(int a, int b)
        {
            Result = MathOperations.Subtraction.Result(a, b);
            return Result;

        }
    }
}
