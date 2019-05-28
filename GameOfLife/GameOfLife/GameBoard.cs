using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class GameBoard 
    {
        private const int Rows = 10;
        private const int Columns = 10;
        public bool[,] boardState = new bool[Rows, Columns];
        public bool isCellChecked = false;

        public GameBoard()
        {
            for (int row = 0; row < Rows; row++)
            {
                for (int col = 0; col < Columns; col++)
                    boardState[row, col] = isCellChecked;                
            }
        }

        public bool GetStateOfSpecificCell(int row, int col)
        {
            return boardState[row, col];
        }

        public bool SwitchStateOfCell(int row, int col)
        {
            if (boardState[row, col] == isCellChecked)
                boardState[row, col] = true;
            else
                boardState[row, col] = isCellChecked;

            return boardState[row, col];
        }


        //public void DisplayBoard()
        //{
        //    for (int row = 0; row < Rows; row++)
        //    {
        //        string row1 = "| ";
        //        string row2 = "";

        //        for (int col = 0; col < Columns; col++)
        //        {
        //            row1 = row1 + boardState[row, col] + " | ";
        //            row2 += "+---";
        //        }
        //        Console.WriteLine(row1);
        //        Console.WriteLine(row2 + "+");
        //    }
        //}
    }
}
