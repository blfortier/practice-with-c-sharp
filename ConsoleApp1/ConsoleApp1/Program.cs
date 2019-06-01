using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            string sentence = "Hello there";
            int columnNumber = 5;

            // Console.WriteLine(Wrapper(sentence, columnNumber));
            int counter = 0;

            StringBuilder sb = new StringBuilder();

            foreach (var c in sentence)
            {
                sb.Append(c);
                if ((++counter % columnNumber) == 0)
                    sb.Append("!");

            }

            Console.WriteLine(sb.ToString());





       //     Console.WriteLine(Regex.Replace(sentence, ".{columnNumber}", "$0!"));



        }

        public static string Wrapper(string sent, int LinkeBreak)
        {
            if (sent.Length == 0 || LinkeBreak == sent.Length)
                return sent;

            var sb = new StringBuilder(sent);
            int counter = 0;

            Console.WriteLine(3 % 9);

            while (counter != LinkeBreak)
            {
                for (int i = 0; i < sent.Length; i++)
                {

                }
            }

            return sent;
        }
    }
}
