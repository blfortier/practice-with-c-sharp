using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Staircase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Size of staircase: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Staircase(n);
        }

        private static void Staircase(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                for (int k = 0; k <= n - 1 - i; k++)
                    Console.Write(" ");
                for (int j = 0; j < i + 1 + 1; j++)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }
        }
    }
}
