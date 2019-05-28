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

            board.SetSetAllBoardStatesToFalse();
            //  board.DisplayBoard();
            Console.WriteLine(board.boardState[5, 4]);
        }
    }
}