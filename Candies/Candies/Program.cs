using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many children: ");
            int children = Convert.ToInt32(Console.ReadLine());

            Console.Write("How many pieces of candy: ");
            int candy = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("In total, {0} pieces of candy will be eaten.", Candies(children, candy));
        }

        public static int Candies(int n, int m)
        {
            int numberOfCandies = m;

            if (n == 1)
                return numberOfCandies;
            else
                numberOfCandies = (m / n) * n;

            return numberOfCandies;
        }
    }  
}
