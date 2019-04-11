using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmendAString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a sentence with no spaces, and upper case for each word: ");
            string sentence = Console.ReadLine();

            Console.WriteLine(AmendTheSentence(sentence));
        }

        public static string AmendTheSentence(string s)
        {
            StringBuilder spaced = new StringBuilder();

            foreach (char c in s)
            {
                if (Char.IsUpper(c) && spaced.Length > 0)
                    spaced.Append(' ');
                spaced.Append(c);
            }

            return spaced.ToString().ToLower();
        }

    }
}
