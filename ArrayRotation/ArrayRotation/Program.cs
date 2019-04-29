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
          

            Console.Write("Rotate array by how many: ");
            var rotateLeftBy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Rotate array left or right? ");
            var direction = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Original array: ");
            foreach (var item in origArr)
            {
                Console.Write(item);
            }
            Console.WriteLine();

            Console.WriteLine("Rotated array: ");
            foreach (var item in RotateArray(origArr, rotateLeftBy, direction))
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }

        public static int[] RotateArray(int[] arr, int numSpacesToMove, string leftOrRight)
        {
            int maxIndex = arr.Length - 1;

            if (leftOrRight == "left" || leftOrRight == "L" || leftOrRight == "l")
            {
                for (int i = 0; i < numSpacesToMove; i++)
                {
                    int temp = arr[0];

                    for (int j = 0; j < maxIndex; j++)
                        arr[j] = arr[j + 1];

                    arr[maxIndex] = temp;
                }

                return arr;
            }
            else 
            {
                for (int i = 0; i < numSpacesToMove; i++)
                {
                    int temp = arr[maxIndex];

                    for (int j = maxIndex; j > 0; j--)
                        arr[j] = arr[j - 1];

                    arr[0] = temp;
                }

                return arr;
            }
        }
    }
}
