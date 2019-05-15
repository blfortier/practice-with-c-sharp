using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMultiple
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a divisor and a bound, find the largest integer N such that:
             * N is divisible by divisor.
             * N is less than or equal to bound.
             * N is greater than 0.
             */

            Console.Write("What's the divisor (int)? ");
            int divisor = Convert.ToInt32(Console.ReadLine());

            Console.Write("What's the bound (int)? " );
            int bound = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The max multiple is {0}.", MaxMultiple(divisor, bound));
        }

        public static int MaxMultiple(int divisor, int bound)
        {
            return bound - (bound % divisor);
        }
    }
}
