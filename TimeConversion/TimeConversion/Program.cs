using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TimeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter time in hh:mm:ssAM/PM format: ");
            string s = Console.ReadLine();
            string result = TimeConversion(s);

            Console.WriteLine("24 hour format: {0}", result);          
        }

        static string TimeConversion(string s)
        {
            string hour = s.Substring(0, 2);
            string minutes = s.Substring(3, 2);
            string seconds = s.Substring(6, 2);
            string amOrPm = s.Substring(8, 2);

            int hourConvert = Convert.ToInt32(hour);
            string newHour = "";         
           
            if (amOrPm == "AM")
            {
                if (hourConvert == 12)
                {
                    return "00" + ":" + minutes + ":" + seconds;
                }
                return s.Substring(0, 7);
            }
            else if (amOrPm == "PM")
            {
                if (hourConvert == 12)
                    return hour + ":" + minutes + ":" + seconds;

                newHour = Convert.ToString(hourConvert + 12);
                return newHour + ":" + minutes + ":" + seconds;
            }

            return "";
        }
    }
}
