using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 3, 5, 12, 2, 0, 8, 4, 10};

            Console.WriteLine("Your sorted list is: ");
            foreach (var item in SplitList(numbers))
            {
                Console.Write(" {0} ", item);
            }
            Console.WriteLine();
        }

        public static List<int> SplitList(List<int> numbersToSort)
        {
            if (numbersToSort.Count == 1)
                return numbersToSort;

            List<int> listLeft = new List<int>();
            List<int> listRight = new List<int>();

            var middleOfList = numbersToSort.Count / 2;

            for (int i = 0; i < middleOfList; i++)
                listLeft.Add(numbersToSort[i]);
            for (int i = middleOfList; i < numbersToSort.Count; i++)
                listRight.Add(numbersToSort[i]);

            listLeft = SplitList(listLeft);
            listRight = SplitList(listRight);

            return Merge(listLeft, listRight);
        }

        public static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> listOfSortedNumbers = new List<int>();

            do
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First())
                    {
                        listOfSortedNumbers.Add(left.First());
                        left.Remove(left.First());
                    }
                    else
                    {
                        listOfSortedNumbers.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    listOfSortedNumbers.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    listOfSortedNumbers.Add(right.First());
                    right.Remove(right.First());
                }             
            }
            while (left.Count > 0 || right.Count > 0);

            return listOfSortedNumbers;
        }
    }
}
