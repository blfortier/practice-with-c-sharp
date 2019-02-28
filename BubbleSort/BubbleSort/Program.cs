using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many integers in the array? ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the ints seperated by a space");
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            int temp;
            var numberOfSwaps = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;

                        numberOfSwaps++;
                    }
                }

                if (numberOfSwaps == 0)
                    break; 
            }

            Console.WriteLine("Array is sorted in {0} swaps.", numberOfSwaps);
            Console.WriteLine("First Element: {0}", a[0]);
            Console.WriteLine("Last Element: {0}", a[n -1]);
            Console.WriteLine();
        }
    }
}
