using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConnectFour
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows: ");
            int row = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number of columns: ");
            int column = Convert.ToInt32(Console.ReadLine());

            Game game = new Game('X', 'O', row, column);
            game.gameBoard.SetBoard();
          //  game.gameBoard.DrawBoard();

            game.ApplyMove(4, 1);
            game.ApplyMove(2, 6);
            game.ApplyMove(5, 1);
            game.ApplyMove(6, 7);
            game.ApplyMove(3, 7);
            game.ApplyMove(6, 2);


            game.gameBoard.DisplayMoves();
        }
    }
}
