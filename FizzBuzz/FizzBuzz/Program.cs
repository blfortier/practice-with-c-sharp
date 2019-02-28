 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace FizzBuzz
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [TestCase("Fizz", 3)]
        [TestCase("Fizz", 6)]
        [TestCase("Buzz", 5)]
        [TestCase("FizzBuzz", 15)]
        [TestCase("FizzBuzz", 30)]
        [TestCase("Buzz", 10)]
        [TestCase("", 7)]
        public void TestFizzBuzz(string expected, int num)
        {
            Assert.AreEqual(expected, FizzBuzz(num));
        }

        private string FizzBuzz(int num)
        {
            if (num % 15 == 0)
                return "FizzBuzz";
            else if (num % 3 == 0)
                return "Fizz";
            else if (num % 5 == 0)
                return "Buzz";
            else
                return "";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
