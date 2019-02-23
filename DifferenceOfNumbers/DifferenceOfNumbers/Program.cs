using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DifferenceOfNumbers
{
    class Difference
    {
        private readonly int[] _elements;
        public int maximumDifference;

        public Difference(int[] numbers)
        {
            _elements = numbers;
        }

        public int ComputeDifference()
        {
           return maximumDifference = _elements.Max() - _elements.Min();
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many elements in the array? ");
            Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter space seperated numbers: ");
            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.ComputeDifference();

            Console.Write(d.maximumDifference);
        }
    }
}
