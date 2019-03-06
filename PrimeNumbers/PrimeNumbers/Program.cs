using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeNumbers
{  
    class Program
    {     
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of test cases: ");
            var input = Convert.ToInt32(Console.ReadLine());

            while (input-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                IsPrime(data);               
            }            
        }

        private static void IsPrime(int data)
        {
            bool isPrime = true;            
            
            for (var i = 2; i <= Math.Sqrt(data); i++)
            {
                if (data % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            Console.WriteLine(isPrime ? "Prime." : "Not prime.");
        }
    }
}
