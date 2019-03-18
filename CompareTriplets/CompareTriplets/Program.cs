using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CompareTriplets
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = compareTriplets(a, b);

            textWriter.WriteLine(String.Join(" ", result));

            textWriter.Flush();
            textWriter.Close();
        }

        static List<int> compareTriplets(List<int> a, List<int> b)
        {

            var alicePoints = 0;
            var bobPoints = 0;
            List<int> points = new List<int>();

            for (var i = 0; i < a.Count; i++)
            {
                for (var j = 0; j < b.Count; j++)
                {
                    if (a[i] > b[j])
                        alicePoints++;
                    else if (a[i] < b[j])
                        bobPoints++;
                }
            }

            points.Insert(0, alicePoints);
            points.Insert(1, bobPoints);

            return points;
        }
    }
}
