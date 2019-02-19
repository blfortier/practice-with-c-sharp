using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Factorialize
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to see it's factorial: ");
            var input = Convert.ToInt32(Console.ReadLine());
            int result = Factorial(input);

            int Factorial(int num)
            {
                if (num == 0 || num == 1)
                    return 1;
                else
                    return (num * Factorial(num - 1));
            }

            Console.WriteLine(result);
        }

    }

    
}
