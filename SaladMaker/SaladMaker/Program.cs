using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaladMaker.IngredientOptions;

namespace SaladMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use the factory method design pattern to
            // make a couple of Salad objects

            var chickenSalad = new ChickenSaladExtraRanch();
            var steakSalad = new DeluxeSalad();

            Console.WriteLine("You have 2 sandwiches!");
        }
    }
}
