using System;
using MathOperations;

namespace Addition
{

    public class Adding : IAdd
    {
        private dynamic Result;

        public dynamic Sum(dynamic a, dynamic b)
        {

            Result = MathOperations.Addition.Sum(a, b);
            return Result;
        }
        public dynamic Sum(dynamic arrayList)
        {
            Result = MathOperations.Addition.Sum(arrayList);
            return Result;
        }

    }
}
