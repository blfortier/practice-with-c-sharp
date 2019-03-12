using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bitwise
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] nk = Console.ReadLine().Split(' ');

                int n = Convert.ToInt32(nk[0]);

                int k = Convert.ToInt32(nk[1]);

                result = CheckMaxValue(n, k);
                Console.WriteLine(result);
            }

        }

        public static int CheckMaxValue(int num1, int num2)
        {            
            int bitwise;
            int max = 0;

            for (var a = 1; a < num1; a++)
            {
                for (var b = a + 1; b <= num1; b++)
                {
                   // Console.WriteLine("a: {0}  b: {1}", a, b);
                    bitwise = a & b;
                  //  Console.WriteLine(bitwise);
                    if (bitwise < num2 && max < bitwise)
                    {
                        max = bitwise;
                  //      Console.WriteLine("max: {0}", max);
                    }
                }
            }

            return max;
        }

    }   
}
