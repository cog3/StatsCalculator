using System;
using System.Collections.Generic;

namespace DescriptiveStats
{
    class DescriptiveStats
    {
        public static double Mean(int[] arr)
        {
            int size = arr.Length;
            int total = 0;
            foreach(int num in arr)
            {
                total += num;
            }
            return total / size;
        }
        public static dynamic Median(int[] arr)
        {
            int size = arr.Length;
            int halfIndex = size / 2;
            Array.Sort(arr);
            double median;
            if ((size % 2) == 0)
            {
                median = (arr[halfIndex] + arr[halfIndex -1]) / 2;
            }
            else
            {
                median = arr[halfIndex];
            }
            return median;
        }
        public static int Mode(int[] x)
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();
            foreach (int a in x)
            {
                if (counts.ContainsKey(a))
                    counts[a] = counts[a] + 1;
                else
                    counts[a] = 1;
            }

            int result = int.MinValue;
            int max = int.MinValue;
            foreach (int key in counts.Keys)
            {
                if (counts[key] > max)
                {
                    max = counts[key];
                    result = key;
                }
            }

            return result;        
        }
        public static double getVariance()
        {
            int[] arr = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
            double mean = Mean(arr);
            double temp = 0;
            foreach (double a in arr)
                temp += (a - mean) * (a - mean);
            return temp / (arr.Length - 1);
        }

        public static double getStdDev()
        {
            return Math.Sqrt(getVariance());
        }

        public static double skewness(int[] arr, int n)
        {
            // Find skewness using 
            // above formula 
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum = (arr[i] - Mean(arr)) *
                    (arr[i] - Mean(arr)) *
                    (arr[i] - Mean(arr));
            }


            return (double)sum / (n * getStdDev() * getStdDev() * getStdDev() * getStdDev());
        }

        public static double Correlation(int[] X, int[] Y, int n)
        {
            int sum_X = 0, sum_Y = 0, sum_XY = 0;
            int squareSum_X = 0, squareSum_Y = 0;

            for (int i = 0; i < n; i++)
            {
                sum_X = sum_X + X[i];
                sum_Y = sum_Y + Y[i];
                sum_XY = sum_XY + X[i] * Y[i];
                squareSum_X = squareSum_X + X[i] * X[i];
                squareSum_Y = squareSum_Y + Y[i] * Y[i];
            }
            double corr = (double)(n * sum_XY - sum_X * sum_Y) /
                         (double)(Math.Sqrt((n * squareSum_X -
                         sum_X * sum_X) * (n * squareSum_Y -
                         sum_Y * sum_Y)));

            return corr;
        }
            
    }
}
