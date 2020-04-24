using System;
namespace Subtraction
{

    public class Difference : ISubtract
    {
        private dynamic Result;

        public int Subtract(int a, int b)
        {
            Result = Result(a, b);
            return Result;

        }
    }
}
