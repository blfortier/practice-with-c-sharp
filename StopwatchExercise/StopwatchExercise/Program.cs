using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace StopwatchExercise
{
    class Program
    {
        static void Main(string[] args)     
        {
            // Instantiate a new stopwatch object
            var stopwatch = new Stopwatch();

            // Start and stop the stopwatch
            for (var i = 0; i < 2; i++)
            {
                stopwatch.Start();

                Thread.Sleep(1000);

                stopwatch.Stop();
            }            

            // Print how long the stopwatch was running 
            Console.WriteLine("Duration is {0}", stopwatch.Duration());
        }
    }
}
