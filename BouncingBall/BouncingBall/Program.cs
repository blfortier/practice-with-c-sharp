using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BallBounce
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Height of floor ball was dropped from: ");
            var throwHeight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Bounce rate: ");
            var rateOfBounce = Convert.ToDouble(Console.ReadLine());

            Console.Write("Window height: ");
            var window = Convert.ToDouble(Console.ReadLine());

            var numBounces = BouncingBall.BallBounces(throwHeight, rateOfBounce, window);
            Console.WriteLine(numBounces);
        }
    }
}
