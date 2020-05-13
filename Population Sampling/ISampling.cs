using System;
using System.Collections.Generic;
using System.Text;

namespace Population_Sampling
{
    class ISampling
    {
        public dynamic[] randomSample(dynamic[] list);
        public dynamic[] systematicSample(dynamic[] list);
        public dynamic[] confidenceInterval(dynamic[] list);
        public double marginOfError();
        public void coachran();
        public voif findSamepleSize(double stdDev, double ci, double width);
        public voif findSamepleSize(double ci, double width);
    }
}
