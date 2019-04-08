using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number between 1 and 9: ");
            int largest = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Largest possible number: {0}", LargestNumber(largest));
        }

        public static int LargestNumber(int n)
        {
            string concat = "";

            for (int i = 0; i < n; i++)
                concat += "9";

            return Convert.ToInt32(concat);
        }
    }
}
