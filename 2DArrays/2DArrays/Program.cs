using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2DArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[6][];
            int temp;
            int max = 0;

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp)); 
            }

            for (int row = 0; row < 4; row++)
                {
                    for (int col = 0; col < 4; col++)
                    {
                        temp = arr[row][col] + arr[row][col + 1] + arr[row][col + 2] + arr[row + 1][col + 1] + arr[row + 2][col] + arr[row + 2][col + 1] + arr[row + 2][col + 2];

                        if (max < temp)
                            max = temp;
                    }
                }

                Console.WriteLine(max);
        }
    }
}
