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
            double[] costPerMin = { 0.2, 0.35, 0.4, 0.45 };
            double[] costPerMile = { 1.1, 1.8, 2.3, 3.5 };

            var rideData = new UberRates(30, 7, costPerMin, costPerMile);
            Console.WriteLine(rideData.ride_time);
            rideData.ride_time = 35;
            Console.WriteLine(rideData.ride_time);
            
            foreach (double cost in rideData.CalculateRates(rideData))
                Console.WriteLine(cost);
        }
    }

    public class UberRates
    {
        private int _ride_time;
        private int _ride_distance;
        private double[] _cost_per_minute;
        private double[] _cost_per_mile;

        public UberRates()
        {
        }

        public UberRates(int rideTime, int rideDist, double[] costPerMin, double[] costPerMile )
        {
            this._ride_time = rideTime;
            this._ride_distance = rideDist;
            this._cost_per_minute = costPerMin;
            this._cost_per_mile = costPerMile;
        }

        public double[] CalculateRates(UberRates data)
        {
            double[] cost = new double[_cost_per_minute.Length];

            for (int i = 0; i < _cost_per_minute.Length; i++)
                cost[i] = (_cost_per_minute[i] * _ride_time) + (_cost_per_mile[i] * _ride_distance);

            return cost;
        }
    }
}
