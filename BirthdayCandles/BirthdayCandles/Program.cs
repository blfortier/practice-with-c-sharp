using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BirthdayCandles
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            Console.Write("How many candles? ");
            int arCount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter space seperated integers, representing candle height");
            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            
            int result = BirthdayCakeCandles(ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }

        static int BirthdayCakeCandles(int[] ar)
        {
            // int max = ar.Max();
            int max = 0;
            int count = 0;

            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] > max)
                    max = ar[i];
            }

            foreach (var item in ar)
            {
                if (item == max)
                    count++;
            }

            Console.WriteLine(count);
            return count;

        }
    }
}

