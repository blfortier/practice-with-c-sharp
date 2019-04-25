using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] origArr = new int[6] { 1, 2, 3, 4, 5, 6};
          

            Console.Write("Rotate array left by how many: ");
            var rotateLeftBy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Original array: ");
            foreach (var item in origArr)
            {
                Console.Write(item);
            }
            Console.WriteLine();

            Console.WriteLine("Rotated array: ");
            foreach (var item in RotateArray(origArr, rotateLeftBy))
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }

        public static int[] RotateArray(int[] arr, int numSpacesToMove)
        {
            int maxIndex = arr.Length - 1;

            for (int i = 0; i < numSpacesToMove; i++)
            {
                int temp = arr[0];

                for (int j = 0; j < maxIndex; j++)
                    arr[j] = arr[j + 1];

                arr[maxIndex] = temp;
            }

            return arr;
        }
    }
}
