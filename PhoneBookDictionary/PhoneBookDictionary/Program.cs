using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhoneBookDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many entries into the phonebook: ");
            // Get number of entries from user
            int numberOfEntries = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // Create a new dictionary called phoneBook
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            // For every entry into the dictionary, take the input string
            // and split it at the space. Store as a 2 element string array
            for (int i = 0; i < numberOfEntries; i++)
            {
                Console.Write("Enter name and number: ");
                string[] input = Console.ReadLine().Split(' ');

                // Add name and number to dictionary
                phoneBook.Add(input[0], input[1]);
                Console.WriteLine("Added to phonebook...");
            }

            Console.WriteLine();
            // To store the search term
            string search = "";

            Console.Write("Search for: ");
            // While a name to search for is still being entered, 
            // search dictionary and print results
            while ((search = Console.ReadLine()) != null && search != "")
            {
                if (phoneBook.ContainsKey(search))
                    Console.WriteLine("{0} = {1}", search, phoneBook[search]);
                else
                    Console.WriteLine("Not found");
            }
        }
    }
}
