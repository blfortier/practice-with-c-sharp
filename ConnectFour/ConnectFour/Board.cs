using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour
{
    public class Board
    {
        private int _rows;
        private int _columns;
        public Colors[,] board;

        Colors Blue = Colors.Blue;
        Colors Gray = Colors.Gray;
        Colors Red = Colors.Red;

        public int Rows { get => _rows; set => _rows = value; }
        public int Columns { get => _columns; set => _columns = value; }
    
        public Board(int numOfRows, int numOfColumns)
        {
            this.Rows = numOfRows;
            this.Columns = numOfColumns;
            this.board = new Colors[this.Rows, this.Columns];

            for (int row = 0; row < Rows; row++)
            {
                for (int col = 0; col < Columns; col++)
                {
                    board[row, col] = Colors.Gray;
                }
            }
        }

        public enum Colors
        {
            Gray,
            Red,
            Blue
        }

        public static void DisplayBoard(Colors[,] board)
        {
            for (int row = 0; row < board.GetLength(0); row++)
            {
                string row1 = "| ";
                string row2 = "";

                for (int col = 0; col < board.GetLength(1); col++)
                {
                    row1 = row1 + board[row, col] + " | ";
                    row2 += "+------";
                }
                Console.WriteLine(row1);
                Console.WriteLine(row2 + "+");
            }
        }

        public static bool CheckCellForNeighborsToRight(Colors[,] board)
        {
            Colors Blue = Colors.Blue;
            Colors Gray = Colors.Gray;
            Colors Red = Colors.Red;

            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    if (board[row, col] == Blue && board[row, col + 1] == Blue)
                        return true;

                    if (board[row, col] == Red && board[row, col + 1] == Red)
                        return true;
                }
            }

            return false;
        }


        public static bool CheckCellForNeighborsToLeft(Colors[,] board)
        {
            Colors Blue = Colors.Blue;
            Colors Gray = Colors.Gray;
            Colors Red = Colors.Red;

            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    if (board[row, col] == Blue && board[row, col - 1] == Blue)
                        return true;

                    if (board[row, col] == Red && board[row, col - 1] == Red)
                        return true;
                }
            }

            return false;
        }

        public static bool CheckCellForNeighborsToLeftDiagUpper(Colors[,] board)
        {
            Colors Blue = Colors.Blue;
            Colors Gray = Colors.Gray;
            Colors Red = Colors.Red;

            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    if (board[row, col] == Blue && board[row - 1, col - 1] == Blue)
                        return true;

                    if (board[row, col] == Red && board[row - 1, col - 1] == Red)
                        return true;
                }
            }

            return false;
        }

        public static bool CheckCellForNeighborsToLeftDiagLower(Colors[,] board)
        {
            Colors Blue = Colors.Blue;
            Colors Gray = Colors.Gray;
            Colors Red = Colors.Red;

            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    if (board[row, col] == Blue && board[row + 1, col - 1] == Blue)
                        return true;

                    if (board[row, col] == Red && board[row + 1, col - 1] == Red)
                        return true;
                }
            }

            return false;
        }

        public static bool CheckCellForNeighborsToRightDiagUpper(Colors[,] board)
        {
            Colors Blue = Colors.Blue;
            Colors Gray = Colors.Gray;
            Colors Red = Colors.Red;

            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    if (board[row, col] == Blue && board[row - 1, col + 1] == Blue)
                        return true;

                    if (board[row, col] == Red && board[row - 1, col + 1] == Red)
                        return true;
                }
            }

            return false;
        }

        public static bool CheckCellForNeighborsToRightDiagLower(Colors[,] board)
        {
            Colors Blue = Colors.Blue;
            Colors Gray = Colors.Gray;
            Colors Red = Colors.Red;

            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    if (board[row, col] == Blue && board[row + 1, col + 1] == Blue)
                        return true;

                    if (board[row, col] == Red && board[row + 1, col + 1] == Red)
                        return true;
                }
            }

            return false;
        }
    }
}
