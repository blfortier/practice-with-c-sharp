using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeReview
{
    class Board
    {
        public int rows;
        public int columns;
        public char[,] board;
        public Dictionary<int, int> columnCount;
       
        public Board(int rows, int columns)
        { 
            if (IsNotValid(rows, columns))
            {
                Console.WriteLine("Please enter numbers between 2 and 30");
                Console.WriteLine("Board not initialized...");
            }
            else
            {
                this.rows = rows;
                this.columns = columns;
            }

            this.board = SetBoard();

            columnCount = new Dictionary<int, int>();
            for (int dictKey = 0; dictKey < this.columns; dictKey++)
                columnCount.Add(dictKey, 0);

        }

        private static bool IsNotValid(int rows, int columns)
        {
            return rows < 4 || rows > 30 || columns < 4 || columns > 30;
        }

        public char[,] SetBoard()
        {
            board = new char[this.rows, this.columns];

            for (int row = 0; row < this.rows; row++)
            {
                for (int column = 0; column < this.columns; column++)
                {
                    board[row, column] = ' ';
                }
            }

            return board;
        }

        public void DrawBoard()
        {
            for (int i = 0; i < this.rows; i++)
            {
                string row1 = "| ";
                string row2 = "";

                for (int j = 0; j < this.columns; j++)
                {
                    row1 = row1 + board[i, j] + " | ";
                    row2 = row2 + "+---";
                }
                Console.WriteLine(row1);
                Console.WriteLine(row2 + "+");
            }

            Console.WriteLine();            
        }

       
    }
}
