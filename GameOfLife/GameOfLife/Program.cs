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
         //   board.boardState[8, 5] = true;
         //   board.boardState[10, 5] = true;

            board.SwitchStateOfCell(6, 5);
            board.SwitchStateOfCell(2, 10);
            board.SwitchStateOfCell(13, 7);

            //     int result = board.CountDiagonalNeig
           // board.GetAllActiveCellsInBoard();

            foreach (var item in board.GetAllActiveCellsInBoard())
            {
                Console.WriteLine("[{0}, {1}]", item[0], item[1]);
            }

            //int result = board.CountVerticalNeighborsOfCell(9, 5);
            //Console.WriteLine(result);
        }
    }
}