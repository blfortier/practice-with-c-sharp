using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter a letter: ");
            //string S = Console.ReadLine();

            //try
            //{
            //    int converted = Convert.ToInt32(S);
            //    Console.WriteLine(converted);
            //}
            //catch
            //{
            //    Console.WriteLine("Bad String");
            //}

            Calculator myCalculator = new Calculator();
            Console.WriteLine("Enter the number of test cases, followed 2 space seperated integers: ");
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                string[] num = Console.ReadLine().Split();
                int n = int.Parse(num[0]);
                int p = int.Parse(num[1]);
                try
                {
                    int ans = myCalculator.power(n, p);
                    Console.WriteLine(ans);
                }
                catch (System.Exception e)
                {
                    Console.WriteLine(e.Message);

                }
            }
        }

        class Calculator
        {
            public int power(int n, int p)
            {
                if (n < 0 || p < 0)
                    throw new System.Exception("n and p should be non-negative");
                else
                    return Convert.ToInt32(Math.Pow(n, p));
            }
        }
    }
}
