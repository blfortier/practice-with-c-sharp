using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThreeOptions.Models
{
    public class Board
    {
        public const int Rows = 4;
        public const int Columns = 4;
        public bool[,] boardState;
        public bool isCellChecked = false;

        public void GameBoard()
        {
            this.boardState = new bool[Rows, Columns];

            for (int row = 0; row < Rows; row++)
            {
                for (int col = 0; col < Columns; col++)
                    this.boardState[row, col] = isCellChecked;
            }
        }
    }
}
