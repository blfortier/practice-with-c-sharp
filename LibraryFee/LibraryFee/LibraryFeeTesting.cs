using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryFee
{
    [TestFixture]
    class LibraryFeeTesting
    {
        [Test]
        public void CalcuLateFine_OnOrBeforeDueDate_NoFine()
        {
            Assert.AreEqual(0, CalculateFine("5 5 2018", "5 5 2018"));
            Assert.AreEqual(0, CalculateFine("3 7 2013", "4 5 2013"));
        }

        [Test]
        public void CalculateFine_DaysLate_Fine()
        {
            Assert.AreEqual(105, CalculateFine("4 8 2018", "4 1 2018"));
        }

        [Test]
        public void CalculateFine_MonthsLate_Fine()
        {
            Assert.AreEqual(3000, CalculateFine("7 18 2017", "1 9 2017"));
        }

        [Test]
        public void CalculateFine_YearsLate_Fine()
        {
            Assert.AreEqual(10000, CalculateFine("1 2 2018", "1 5 2015"));
        }

        public int CalculateFine(string returned1, string due1)
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
