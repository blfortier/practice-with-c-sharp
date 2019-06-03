using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class Program
    {
        static void Main(string[] args)
        {
            var board = new GameBoard();
            board.boardState[8, 5] = true;
            board.boardState[10, 5] = true;

            Console.WriteLine(board.GetStateOfCell(8, 5));
            Console.WriteLine(board.GetStateOfCell(8, 7));
            Console.WriteLine(board.GetStateOfCell(10, 5));
            Console.WriteLine(board.GetStateOfCell(10, 7));

            //     int result = board.CountDiagonalNeighorsOfCell(9, 6);

            int result = board.CountVerticalNeighborsOfCell(9, 5);
            Console.WriteLine(result);
        }
    }
}