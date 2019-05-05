using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeArrayConsec
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many integers in array: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the integers in the array: ");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            Console.WriteLine("You would need to add {0} numbers to make the array consecutive", MakeArrayConsecutive(arr));            
        }

        public static int MakeArrayConsecutive(int[] statues)
        {
            Array.Sort(statues);
            int count = 0;
            int offset = 0;

            for (int i = 0; i < statues.Length - 1; i++)
            {
                if (statues[i + 1] != statues[i] + 1)
                {
                    count += statues[i + 1] - statues[i];
                    offset++;
                }
            }

            return count - offset;
        }
    }
}
