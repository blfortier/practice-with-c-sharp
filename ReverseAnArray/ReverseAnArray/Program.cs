using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReverseAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers in the array: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter numbers seperated by a space: ");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            for (var i = n - 1; i >= 0; i--)
                Console.Write("{0} ", arr[i]);
            Console.WriteLine();

        }
    }    
}
