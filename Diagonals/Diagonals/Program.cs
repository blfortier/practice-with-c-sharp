using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagonals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many rows and columns: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter each row below: ");
            int[][] arr = new int[n][];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = DiagonalDifference(arr);

            Console.WriteLine(result);
        }

        public static int DiagonalDifference(int[][] arr)
        {
            int sumOfLeftDiagonal = arr[0][0] + arr[1][1] + arr[2][2];
            int sumOfRightDiagonal = arr[0][2] + arr[1][1] + arr[2][0];

            return Math.Abs(sumOfLeftDiagonal - sumOfRightDiagonal);
        }
    }
}
