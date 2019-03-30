using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeReview
{
    class Program
    {
        static void Main(string[] args)
        {
            // BF -- I know r stands for row, but somebody reading
            // your code may not realize this. row would be a good choice
            Console.WriteLine("Enter the number of rows: ");
            int r = Convert.ToInt32(Console.ReadLine());

            // BF -- I know c stands for column, but somebody reading
            // your code may not realize this. column would be a good choice
            Console.WriteLine("Enter the number of columns: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("DrawBoard3 Pattern: ");
            DrawDynamicBoard.DrawBoard3(r, c);
        }
    }
}
