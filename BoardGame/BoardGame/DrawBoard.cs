using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoardGame
{
    public class Board
    {
        private int _height;
        private int _width;          

        public Board(int height, int width)
        {
            _height = height;
            _width = width;

            DrawBoard(height, width);
        }

        public void DrawBoard(int height, int width)
        {
            DrawTopBorder(width);

            for (var i = 0; i < height; i++)       
                DrawCells(width);
        }       

        public void DrawTopBorder(int width)
        {
            for (var i = 0; i < width; i++)
                Console.Write("+--");
            Console.WriteLine("+");
        }

        public void DrawCells(int width)
        {
            int j;

            Console.Write("|  ");
            for (j = 0; j < width; j++)
                Console.Write("|  ");

            if (j == width)
            {
                Console.WriteLine();
                for (var i = 0; i < width; i++)
                    Console.Write("+--");
            }

            Console.Write("+\n");
        }
    }
}

