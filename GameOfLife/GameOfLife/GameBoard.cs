using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class GameBoard
    {
        public char[,] boardState = new char[5, 5];

        public void SetInitialState()
        {
            for (int row = 0; row < boardState.GetLength(1); row++)
            {
                for (int col = 0; col < boardState.GetLength(0); col++)
                {
                    boardState[row, col] = 'X';
                }
            }
        }

        public void DisplayBoard()
        {
            for (int row = 0; row < boardState.GetLength(1); row++)
            {
                string row1 = "| ";
                string row2 = "";

                for (int col = 0; col < boardState.GetLength(0); col++)
                {
                    row1 = row1 + boardState[row, col] + " | ";
                    row2 += "+---";
                }
                Console.WriteLine(row1);
                Console.WriteLine(row2 + "+");
            }
        }

        public char InsertCharIntoCell(int row, int col)
        {
            return boardState[row, col] = 'X';
        }
    }
}

