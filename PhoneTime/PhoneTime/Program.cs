using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Rates for first minute: ");
            int input1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Rates for minutes 2 through 10: ");
            int input2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Rates for minutes 11 and on: ");
            int input3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("How many cents in your account? ");
            int cents = Convert.ToInt32(Console.ReadLine());

            PhoneRates rates = new PhoneRates(input1, input2, input3);
            Console.WriteLine("You can talk for {0} minutes.", PhoneCall(rates, cents));
        }

        public static int PhoneCall(PhoneRates rates, int centsInAccount)
        {
            int totalMinutes = 1;

            if (centsInAccount >= rates.FirstMin)
                centsInAccount -= rates.FirstMin;
            else
                return 0;

            if (rates.Mins2_10 * 9 < centsInAccount)
            {
                centsInAccount -= rates.Mins2_10 * 9;
                totalMinutes += (centsInAccount / rates.Min11) + 9;
                return totalMinutes;
            }
            else
                totalMinutes += (centsInAccount / rates.Mins2_10);

            return totalMinutes;

        }
    }
}
