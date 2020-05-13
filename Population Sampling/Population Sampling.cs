using System;
using Random_Generator;
namespace Population_Sampling
{
    class Population_Sampling
    {
        Random ran = new Random();

        public int[] randomSample(dynamic[] list)
        {
            return RandomGenerator.generateList(20, 10, 0, 9, ran);
        }
        public dynamic[] systematicSample(dynamic[] list)
        {
            int count = 0;
            int dynamic_count = 0;
            dynamic[] arr = new dynamic[20];
            while (count < 100)
            {
                if(count % 5 == 0)
                {
                    arr[dynamic_count] =  RandomGenerator.generateListDouble(20, 10, 1.0, 10.0, ran);
                    dynamic_count++;
                }
                count++;
            }
            return arr;
            
        }
        public dynamic[] confidenceInterval(dynamic[] list)
        {
            double sum = 0.0;
            foreach(int num in list)
            {
                sum += num;
            }
            double mean = sum / list.Length;

            // calculate standard deviation
            double squaredDifferenceSum = 0.0;
            foreach(int num in list)
            {
                squaredDifferenceSum += (num - mean) * (num - mean);
            }
            double variance = squaredDifferenceSum / list.Length;
            double standardDeviation = Math.Sqrt(variance);

            double confidenceLevel = 1.96;
            double temp = confidenceLevel * standardDeviation / Math.Sqrt(list.Length);
            return new dynamic[] { mean - temp, mean + temp };
        }
    }
}
