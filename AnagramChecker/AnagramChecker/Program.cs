using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            string path = @"C:\Users\Owner\source\repos\practice-with-c-sharp\AnagramChecker\AnagramChecker\Dictionary.txt";

            if (!File.Exists(path))
                Console.WriteLine("Error reading file.");

            string[] readText = File.ReadAllText(path).Split();

            // string sorted = String.Concat(readText.OrderBy(c => c));
            string sorted = "";
            List<int> indexes = new List<int>();

            for (int index =  0; index < readText.Length; index++)
            {
                sorted = SortString(readText[index]);
                if (!dict.ContainsKey(sorted))
                    dict.Add(sorted, 1);
                else
                {
                    dict[sorted]++;
                    indexes.Add(index);
                }
            }
            foreach (var item in dict)
            {
                Console.WriteLine(item);
            }

          // PrintIndexAndKeysAndValues(ht);
            foreach (var item in indexes)
            {
                Console.WriteLine(item);
            }

        }
        public static string SortString(string input)
        {
            char[] chars = input.ToArray();
            Array.Sort(chars);
            return new string(chars);
        }

        public static void PrintIndexAndKeysAndValues(Hashtable myHT)
        {
            int i = 0;
            Console.WriteLine("\t-INDEX-\t-KEY-\t-VALUE-");
            foreach (DictionaryEntry de in myHT)
                Console.WriteLine("\t[{0}]:\t{1}\t{2}", i++, de.Key, de.Value);
            Console.WriteLine();
        }
    }
}
