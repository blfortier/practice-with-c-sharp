using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LateRide
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many minutes have elapsed on the timer? ");
            int n = Convert.ToInt32(Console.ReadLine());

            LateRide(n);
        }

        public static int LateRide(int n)
        {
            int hoursPassed = n / 60;
            int minutesPassed = n % 60;
             
            string join = hoursPassed.ToString() + minutesPassed.ToString();

            int sum = 0;

            for (int i = 0; i < join.Length; i++)
                sum += Int32.Parse(join[i].ToString());

            return sum;
        }
    }
}
