using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Client participant

            Console.Write("Are you an (A)dult or (C)hild? ");
            char input = Console.ReadKey().KeyChar;

            FurnitureFactory factory;

            switch (input)
            {
                case 'A':
                    factory = new AdultFurnitureFactory();
                    break;

                case 'C':
                    factory = new KidFurnitureFactory();
                    break;

                default:
                    throw new NotImplementedException();
            }

            var bed = factory.BuildBed();
            var dresser = factory.BuildDresser();

            Console.WriteLine("\nBed: {0}", bed.GetType().Name);
            Console.WriteLine("Dresser: {0}\n", dresser.GetType().Name);
        }
    }
}
