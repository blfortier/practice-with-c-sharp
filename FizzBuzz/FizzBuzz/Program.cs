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
       [Test]
       public void TestFizzBuzz()
       {
            Assert.AreEqual("Fizz", FizzBuzz(3));
            Assert.AreEqual("Fizz", FizzBuzz(12));
            Assert.AreEqual("Buzz", FizzBuzz(5));
            Assert.AreEqual("Buzz", FizzBuzz(10));
            Assert.AreEqual("FizzBuzz", FizzBuzz(45));
            Assert.AreEqual("FizzBuzz", FizzBuzz(15));

       }

        private string FizzBuzz(int number)
        {
            if (number % 15 == 0)
                return "FizzBuzz";
            else if (number % 3 == 0)
                return "Fizz";
            else if (number % 5 == 0)
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