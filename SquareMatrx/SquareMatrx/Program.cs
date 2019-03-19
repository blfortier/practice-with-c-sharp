using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SquareMatrx
{
    class Program
    {
        static int DiagonalDifference(int[][] arr)
        {

            int sumOfLeftDiagonal = arr[0][0] + arr[1][1] + arr[2][2];
            Console.WriteLine(sumOfLeftDiagonal);

            int sumOfRightDiagonal = arr[0][2] + arr[1][1] + arr[2][0];

            return Math.Abs(sumOfLeftDiagonal - sumOfRightDiagonal);
        }

        static void Main(string[] args)
        {
           // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[][] arr = new int[n][];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = DiagonalDifference(arr);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
    
}
