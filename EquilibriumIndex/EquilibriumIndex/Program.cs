using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquilibriumIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many elements in array: ");
            int numElements = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter array of integers: ");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
       
            
        }

        public static int FindEquilibriumIndex(int n, int[] arr)
        {
            int middle = n / 2;

            if (n % 2 == 0)
                middle
            else
                middle = arr[middle];
            for (int i = 0;)
            return -1;
        }
    }
}
