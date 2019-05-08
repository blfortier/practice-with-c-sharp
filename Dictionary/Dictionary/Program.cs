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
            List<string> magazine = new List<string> { "two", "times", "three", "is", "not", "four"};

            // string[] note = Console.ReadLine().Split(' ');
            List<string> note = new List<string> { "two", "times", "two", "is", "four"};

            checkMagazine(magazine, note);
        }

        public static void checkMagazine(List<string> magazine, List<string> note)
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