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
          
            int maxIndex = origArr.Length - 1;

            Console.Write("Rotate array left by how many: ");
            var rotateLeftBy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < rotateLeftBy; i++)
            {
                int temp = origArr[0];

                for (int j = 0; j < maxIndex; j++)
                    origArr[j] = origArr[j + 1];

                origArr[maxIndex] = temp;
            }

            Console.WriteLine("Rotated array: ");
            foreach (var item in origArr)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
