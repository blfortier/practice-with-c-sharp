using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeirdOrNot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int N = Convert.ToInt32(Console.ReadLine());

            if (N % 2 == 1)
                Console.WriteLine("Weird");
            else
            {
                if (N >= 2 && N <= 5)
                    Console.WriteLine("Not Weird");
                else if (N >= 6 && N <= 20)
                    Console.WriteLine("Weird");
                else
                    Console.WriteLine("Not Weird");
            }


        }
    }
}
