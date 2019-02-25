using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to find the number of consecutive 1's of it's binary form: ");
            var n = Convert.ToInt32(Console.ReadLine());
            string binary = Convert.ToString(n, 2);

            int count = 0;
            int min = 0;

            for (var i = 0; i < binary.Length; i++)
            {
                if (binary[i].Equals('1'))
                {
                    count++;

                    if (count > min)
                        min = count;
                }
                else
                {
                    count = 0;
                }

            }

            Console.WriteLine("Number of consecutive 1's: {0}", min);






        }
    }
}
