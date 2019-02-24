using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a letter: ");
            string S = Console.ReadLine();

            try
            {
                int converted = Convert.ToInt32(S);
                Console.WriteLine(converted);
            }
            catch
            {
                Console.WriteLine("Bad String");
            }

        }
    }
}
