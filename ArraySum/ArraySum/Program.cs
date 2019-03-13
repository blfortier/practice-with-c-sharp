using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of ints in array: ");
            var arrLength = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Array element: ");

            var array = new int[arrLength];
            var sum = 0;

            for (var i = 0; i < arrLength; i++)
            {
                var number = Convert.ToInt32(Console.ReadLine());
                array[i] = number;
                sum += number;
            }

            Console.WriteLine("Sum of the array is: {0}", sum);
        }
       
    }
}
