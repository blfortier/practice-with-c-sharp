using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchingSocks
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int result = SockMerchant(n, ar);

            Console.WriteLine(result);
        }

        public static int SockMerchant(int n, int[] ar)
        {
            int numberOfPairs = 0;
            List<int> pairs = new List<int>();

            for (int i = 0; i < ar.Length; i++)
            {
                if (!pairs.Contains(ar[i]))
                    pairs.Add(ar[i]);
                else
                {
                    numberOfPairs++;
                    pairs.Remove(ar[i]);
                }
            }

            return numberOfPairs;
        }
    }
}
