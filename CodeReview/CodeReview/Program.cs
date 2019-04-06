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

            Console.WriteLine();

            Game game = new Game('X', 'O', row, column);
            game.gameBoard.SetBoard();
            // newGame.gameBoard.DrawBoard();

            game.ApplyMove(1);
            game.ApplyMove(1);
            game.ApplyMove(4);
            game.ApplyMove(6);
            game.ApplyMove(3);

            game.gameBoard.DrawBoard();
        }
    }
}
