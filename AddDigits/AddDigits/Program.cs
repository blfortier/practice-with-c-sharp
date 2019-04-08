using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a two-digit number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int sum = AddTwoDigits(number);

            Console.WriteLine("Sum of digits: {0}", sum);
        }

        public static int AddTwoDigits(int n)
        {

            int firstDigit = Convert.ToInt32(n.ToString().Substring(0, 1));
            int secondDigit = Convert.ToInt32(n.ToString().Substring(1, 1));

            return firstDigit + secondDigit;
        }

    }
}
