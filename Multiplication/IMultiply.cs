using System;
using System.Collections.Generic;
using System.Text;

namespace Multiplication
{
    public interface  IMultiply
    {
        public int Product(int a, int b);
        public decimal Product(decimal a, decimal b);
    }
}
