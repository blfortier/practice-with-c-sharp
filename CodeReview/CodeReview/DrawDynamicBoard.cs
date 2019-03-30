using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeReview
{
    class DrawDynamicBoard
    {
        private static bool isNotValid(int rows, int columns)
        {
            // It's great that you only used one line!
            return rows < 2 || rows > 30 || columns < 2 || columns > 30;
        }

        public static void DrawBoard3(int rows, int columns)
        {
            // Since this if statement is only one line, you
            // can omit the curly braces
            if (isNotValid(rows, columns))
            {
                Console.WriteLine("Please enter numbers between 2 and 30");
            }
            else
            {
                // This is so compact and clean, very nice!
                for (int i = 0; i < rows; i++)
                {
                    string row1 = "|";
                    string row2 = "";

                    for (int j = 0; j < columns; j++)
                    {
                        row1 = row1 + " | ";
                        row2 = row2 + "-+-";
                    }
                    Console.WriteLine(row1);
                    Console.WriteLine(row2);
                }

                Console.WriteLine();
            }
        }
    }
}
