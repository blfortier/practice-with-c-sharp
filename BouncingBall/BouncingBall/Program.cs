using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BallBounce
{
    public class BouncingBall
    {
        public static int bouncingBall(double height, double bounceRate, double windowHeight)
        {
            if (height < 0 || height < windowHeight || bounceRate <= 0 || bounceRate >= 1)
                return -1;

            // Make sure the first initial drop past
            // the window is counted
            var bounce = 1;

            do
            {
                height = height * bounceRate;
                bounce++;

            } while (height > windowHeight);

            return bounce;
        }
    }

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

            var numBounces = BouncingBall.bouncingBall(throwHeight, rateOfBounce, window);
            Console.WriteLine(numBounces);
        }
    }
}
