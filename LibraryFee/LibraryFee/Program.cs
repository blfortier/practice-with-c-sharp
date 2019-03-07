using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryFee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Book returned: ");
            var returned1 = Console.ReadLine();            

            Console.Write("Book due: ");
            var due1 = Console.ReadLine();

            var fine = CalculateFine(returned1, due1);
        }

        public static int CalculateFine(string returned1, string due1)
        {
            var returnDate = returned1.Split(' ').Select(int.Parse).ToArray();
            var dueDate = due1.Split(' ').Select(int.Parse).ToArray();

            var returnedMonth = returnDate[0];
            var returnedDay = returnDate[1];
            var returnedYear = returnDate[2];

            var dueMonth = dueDate[0];
            var dueDay = dueDate[1];
            var dueYear = dueDate[2];

            if (returnedYear > dueYear)
                return 10000;

            if (returnedYear == dueYear)
            {
                if (returnedMonth == dueMonth)
                {
                    if (returnedDay > dueDay)
                        return (15 * (returnedDay - dueDay));
                }
                else if (returnedMonth > dueMonth)
                    return 500 * (returnedMonth - dueMonth);
            }

            return 0;
        }
    }
}
