using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Height of board: ");
            var height = Convert.ToInt32(Console.ReadLine());

            Console.Write("Width of board: ");
            var width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Board board;

            // var height = 4;
            // var width = 6;

            if (IsHeightAndWidthValid(height, width))
                board = new Board(height, width);
            else
                Console.WriteLine("Height and width must be between 2 and 30.\n");



        }

        public static bool IsHeightAndWidthValid(int height, int width)
        {
            return height > 2 && height < 30 && width > 2 && width < 30;
        }
    }
}

