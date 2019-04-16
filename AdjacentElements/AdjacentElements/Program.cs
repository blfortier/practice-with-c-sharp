using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdjacentElements
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Guaranteed Constraints
             *  2 ≤ inputArray.length ≤ 10 
             * -1000 ≤ inputArray[i] ≤ 1000              
             */

            Console.Write("How many elements in the array: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the integers in the array, seperated by a space: ");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            Console.WriteLine("The largest product of adjacent elements is {0}.", AdjacentElementsProduct(arr));
        }

        public static int AdjacentElementsProduct(int[] inputArray)
        {

            int product = -100;

            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                if (inputArray[i] * inputArray[i + 1] > product)
                {
                    product = inputArray[i] * inputArray[i + 1];
                    Console.WriteLine(product);
                }
            }

            return product;
        }
    }
}
