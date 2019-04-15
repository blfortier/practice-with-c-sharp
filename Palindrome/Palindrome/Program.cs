using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string input = Console.ReadLine();

            bool isPalindrom = CheckPalindrome(input);
            Console.WriteLine("Is palindrome: {0}", isPalindrom);
        }

       public static bool CheckPalindrome(string inputString)
        {

            for (int i = 0, j = inputString.Length - 1; i < j; i++, j--)
            {
                if (inputString[i] != inputString[j])
                    return false;
            }

            return true;
        }

    }
}
