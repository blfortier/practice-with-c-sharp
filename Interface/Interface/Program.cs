using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface
{
    public interface AdvancedArithmetic
    {
        int divisorSum(int n);
    }

    public class Calculator : AdvancedArithmetic
    {
        private int sum = 0;
        public int divisorSum(int n)
        {
            for (var i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    sum += i;
            }  
  
            return sum;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an integer: ");
            int n = Int32.Parse(Console.ReadLine());
            AdvancedArithmetic myCalculator = new Calculator();
            int sum = myCalculator.divisorSum(n);
            Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
        }

    }
}
