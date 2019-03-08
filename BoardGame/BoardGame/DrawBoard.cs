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
            if (!IsHeightValid(height))
                throw new ArgumentOutOfRangeException("height", "Height must be between 2 and 30");
            else
                this._height = height;

            if (!IsWidthValid(width))
                throw new ArgumentOutOfRangeException("width", "Width must be between 2 and 30");
            else
                this._width = width;

            DrawBoard(height, width);
        }

        public void DrawBoard(int height, int width)
        {
            int j;
           
            for (var i = 0; i < height; i++)       
            {
                Console.Write("|  ");
                
                for (j = 0; j < width; j++)
                    Console.Write("|  ");                      

                if(j == width)
                {
                    Console.WriteLine();
                    for (var t = 0; t < width; t++)
                        Console.Write("+--");
                }

                Console.Write("+");
                Console.WriteLine();             
            }

            Console.WriteLine();

        }

        private bool IsHeightValid(int height)
        {
            return height > 2 && height < 30;
        }

        private bool IsWidthValid(int width)
        {
            return width > 2 && width < 30;
        }
    }
}

