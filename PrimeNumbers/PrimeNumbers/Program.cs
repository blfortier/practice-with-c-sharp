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

            string result;

            while (input-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                result = IsPrime(data);
                Console.WriteLine(result);

            }

        }

        private static string IsPrime(int data)
        {
            string message;
            bool isPrime;

            if (data == 1)
                isPrime = false;
            if (data == 2)
                isPrime = true;
            
            for (int i = 3; i < data; i++)
            {
                if (data % i == 0)
                    isPrime = false;
            }

            isPrime = true;


            return message = isPrime ? "Prime" : "Not prime";
        }
    }
}
