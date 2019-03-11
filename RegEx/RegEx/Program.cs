using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace RegEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many entries? ");
            int N = Convert.ToInt32(Console.ReadLine());

            // var containsGmail = new List<string>();
            var namesAndEmails = new Dictionary<string, string>();

            for (int NItr = 0; NItr < N; NItr++)
            {
                Console.WriteLine("Format: Name Email");
                string[] firstNameEmailID = Console.ReadLine().Split(' ');

                string firstName = firstNameEmailID[0];           
                string emailID = firstNameEmailID[1];

                namesAndEmails.Add(firstName, emailID);

                //if (IsMatch(emailID, firstName))
                //{
                //    containsGmail.Add(firstName);
                //    Console.WriteLine("name added...");
                //}
            }
                      

            foreach (var name in namesAndEmails)
            {
                Console.WriteLine(name);
            }

        }

        public static bool IsMatch(string email, string name)
        {
            Regex reg = new Regex(@"/(@)([gmail])\w+/g");

            Match result = reg.Match(email);
            if (result.Success)
            {
                return true;
            }
            else
                return false;
        }
    }
}
