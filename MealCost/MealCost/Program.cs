using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MealCost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Meal cost: ");
            double meal_cost = Convert.ToDouble(Console.ReadLine());

            Console.Write("Tip percent: ");
            int tip_percent = Convert.ToInt32(Console.ReadLine());

            Console.Write("Tax percent: ");
            int tax_percent = Convert.ToInt32(Console.ReadLine());

            Console.Write("Total cost of meal: ");
            solve(meal_cost, tip_percent, tax_percent);
        }

        static void solve(double meal_cost, int tip_percent, int tax_percent)
        {
            double tip_cost = (meal_cost * tip_percent) / 100;
            double tax_cost = (meal_cost * tax_percent) / 100;
            double total_cost = Math.Round(meal_cost + tip_cost + tax_cost);
            Console.WriteLine(total_cost);
        }

    }
}
