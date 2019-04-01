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
            //Console.WriteLine("Enter the number of rows: ");
            //int row = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter the number of columns: ");
            //int column = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your board game: ");
            StartGame newGame = new StartGame("X", "O", 6, 7); 
           // DrawDynamicBoard.DrawBoard(row, column);
        }
    }
}
