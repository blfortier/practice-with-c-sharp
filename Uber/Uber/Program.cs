using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Uber
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] costPerMin = new double[] { 0.2, 0.35, 0.4, 0.45 };
            double[] costPerMile = new double[] { 1.1, 1.8, 2.3, 3.5 };

            var rideData = new UberRates(30, 7, costPerMin, costPerMile);
            
            foreach (double cost in rideData.CalculateRates(rideData))
            {
                Console.WriteLine(cost);
            }
        }
    }

    public class UberRates
    {
        public int ride_time { get; set;}
        public int ride_distance { get; set; }
        public double[] cost_per_minute { get; set; }
        public double[] cost_per_mile { get; set; }

        public UberRates()
        {
        }

        public UberRates(int rideTime, int rideDist, double[] costPerMin, double[] costPerMile )
        {
            this.ride_time = rideTime;
            this.ride_distance = rideDist;
            this.cost_per_minute = costPerMin;
            this.cost_per_mile = costPerMile;
        }

        public double[] CalculateRates(UberRates data)
        {
            double[] cost = new double[cost_per_minute.Length];

            for (int i = 0; i < cost_per_minute.Length; i++)
            {
                cost[i] = (cost_per_minute[i] * ride_time) + (cost_per_mile[i] * ride_distance);
            }

            return cost;
        }
    }
}
