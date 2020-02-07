using System;

namespace Result
{
    public interface IResult
    {
        dynamic Result
        {
            get;
            set;
        }

    }
    public class CalculationResult
    {
        private dynamic _result;

        public dynamic Result
        {
            get => _result;
            set => _result = value;
        }
    }
}
