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
            this._height = height;
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
                {
                    Console.Write("|  ");                      
                }

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
    }
}

