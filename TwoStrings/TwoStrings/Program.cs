using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //int q = Convert.ToInt32(Console.ReadLine());

            //for (int qItr = 0; qItr < q; qItr++)
            //{
            //    string s1 = Console.ReadLine();

            //    string s2 = Console.ReadLine();

            //    string result = TwoStrings(s1, s2);

            //    Console.WriteLine(result);
            //}

            string s1 = "cat";
            string s2 = "caterpillar";

            Console.WriteLine(TwoStrings(s1, s2));
        }

        public static string TwoStrings(string s1, string s2)
        {
            char[] s1ToArray = s1.ToCharArray();
            char[] s2ToArray = s2.ToCharArray();
            string result = "No";

            Dictionary<char, int> firstString = new Dictionary<char, int>();

            foreach (var character in s1ToArray)
            {
                if (!firstString.ContainsKey(character))
                    firstString.Add(character, 1);
                else
                    firstString[character]++;
            }

            foreach (var character in s2ToArray)
            {
                if (firstString.ContainsKey(character))
                    result = "Yes";
            }

            return result;
        }
    }
}
