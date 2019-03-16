using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Integer: ");
            var number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The integer reversed is: {0}\n", ReverseOrder(number));          
        }

        public static int ReverseOrder(int num)
        {
            int reversed = 0;
            
            while (num != 0)
            {
                reversed = reversed * 10 + num % 10;
                num = num / 10;
            }                       

            return reversed;
        }
    }
}
