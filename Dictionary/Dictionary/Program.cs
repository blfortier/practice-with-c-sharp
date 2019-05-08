using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RansomNote
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] mn = Console.ReadLine().Split(' ');

            //int m = Convert.ToInt32(mn[0]);

            //int n = Convert.ToInt32(mn[1]);

            //string[] magazine = Console.ReadLine().Split(' ');
            string[] magazine = new string[6] { "two", "times", "three", "is", "not", "four"};

            // string[] note = Console.ReadLine().Split(' ');
            string[] note = new string[5]{ "two", "times", "two", "is", "four"};

            checkMagazine(magazine, note);
        }

        public static void checkMagazine(string[] magazine, string[] note)
        {

            Dictionary<string, int> magazineWords = new Dictionary<string, int>();

            foreach (var word in magazine)
            {
                if (!magazineWords.ContainsKey(word))
                    magazineWords.Add(word, 1);
                else
                    magazineWords[word]++;
            }

            foreach (var word in note)
            {
                if (!magazineWords.ContainsKey(word) || magazineWords[word] < 1)
                {
                    Console.WriteLine("No");
                    return;
                }
                else
                    magazineWords[word]--;
            }

            Console.WriteLine("Yes");
        }
    }
}