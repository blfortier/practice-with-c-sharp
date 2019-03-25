using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Thumbtack
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        int[] RatingThreshold(double threshold, int[][] ratings)
        {

            double[] arrOfAverages = new double[ratings.Length];
            List<int> results = new List<int>();

            for (var i = 0; i < ratings.Length; i++)
            {

                arrOfAverages[i] = ratings[i].Average();

                if (arrOfAverages[i] < threshold)
                    results.Add(i);
            }

            return results.ToArray();
        }

    }
}
