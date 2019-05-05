using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What size interesting polygon: ");
            int size = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The total area is: {0}", FindshapeArea(size));
        }

        public static int FindshapeArea(int n)
        {
            return (int)(n * n + (Math.Pow(n, 2) - 2 * n + 1));
        }
    }
}
