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

        public static Colors GetStateOfCell(Colors[,] board, int row, int col)
        {
            return board[row, col];
        }


        public static bool CheckCellForNeighborsAbove(Colors[,] board)
        {
            Colors Blue = Colors.Blue;
            Colors Red = Colors.Red;

            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    if (board[row, col] == Blue && board[row + 1, col] == Blue)
                        return true;

                    if (board[row, col] == Red && board[row + 1, col] == Red)
                        return true;
                }
            }

            return false;
        }


        //public static bool CheckCellForNeighborsBelow(Colors[,] board)
        //{
        //    Colors Blue = Colors.Blue;
        //    Colors Red = Colors.Red;

        //    for (int row = 0; row < board.GetLength(0); row++)
        //    {
        //        for (int col = 0; col < board.GetLength(1); col++)
        //        {
        //            if (board[row, col] == Blue && board[row - 1, col] == Blue)
        //                return true;

        //            if (board[row, col] == Red && board[row - 1, col] == Red)
        //                return true;
        //        }
        //    }

        //    return false;
        //}

        public static bool CheckCellForNeighborsToRight(Colors[,] board)
        {
            Colors Blue = Colors.Blue;
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

        //public static bool CheckCellForNeighborsToLeftDiagLower(Colors[,] board)
        //{
        //    Colors Blue = Colors.Blue;
        //    Colors Red = Colors.Red;

        //    for (int row = 0; row < board.GetLength(0); row++)
        //    {
        //        for (int col = 0; col < board.GetLength(1); col++)
        //        {
        //            if (board[row, col] == Blue && board[row + 1, col - 1] == Blue)
        //                return true;

        //            if (board[row, col] == Red && board[row + 1, col - 1] == Red)
        //                return true;
        //        }
        //    }

        //    return false;
        //}

        public static bool CheckCellForNeighborsToRightDiagUpper(Colors[,] board)
        {
            Colors Blue = Colors.Blue;
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

        //public static bool CheckCellForNeighborsToRightDiagLower(Colors[,] board)
        //{
        //    Colors Blue = Colors.Blue;
        //    Colors Red = Colors.Red;

        //    for (int row = 0; row < board.GetLength(0); row++)
        //    {
        //        for (int col = 0; col < board.GetLength(1); col++)
        //        {
        //            if (board[row, col] == Blue && board[row + 1, col + 1] == Blue)
        //                return true;

        //            if (board[row, col] == Red && board[row + 1, col + 1] == Red)
        //                return true;
        //        }
        //    }

        //    return false;
        //}

        //public int CountHorizontalNeighborsOfCell(int row, int col)
        //{
        //    int horizontalNeighborCount = 0;

        //    if (col == 0)
        //    {
        //        if (boardState[row, col + 1] == true)
        //            horizontalNeighborCount++;
        //    }
        //    else if (col == _lastColumn)
        //    { 
        //        if (boardState[row, col - 1] == true)
        //            horizontalNeighborCount++;
        //    }
        //    else
        //    {
        //        // horizontal
        //        if (boardState[row, col - 1] == true)
        //            horizontalNeighborCount++;
        //        if (boardState[row, col + 1] == true)
        //            horizontalNeighborCount++;
        //    }

        //    return horizontalNeighborCount;
        //}

        //public int CountVerticalNeighborsOfCell(int row, int col)
        //{
        //    int verticalNeighborCount = 0;

        //    if (row == 0)
        //    {
        //        if (boardState[row + 1, col] == true)
        //            verticalNeighborCount++;
        //    }
        //    else if (row == _lastRow)
        //    {
        //        if (boardState[row - 1, col] == true)
        //            verticalNeighborCount++;
        //    }
        //    else
        //    {
        //        // vertical
        //        if (boardState[row - 1, col] == true)
        //            verticalNeighborCount++;
        //        if (boardState[row + 1, col] == true)
        //            verticalNeighborCount++;
        //    }

        //    return verticalNeighborCount;
        //}


        //public int CountDiagonalNeighorsOfCell(int row, int col)
        //{
        //    int diagonalNeighborCount = 0;
        //    int lastColumn = _lastColumn;
        //    int lastRow = _lastRow;

        //    if (col == 0)
        //    {
        //        if (row == 0)
        //        {
        //            if (boardState[row + 1, col + 1] == true)
        //                diagonalNeighborCount++;
        //        }
        //        else if (row == _lastRow)
        //        {
        //            if (boardState[row - 1, col + 1] == true)
        //                diagonalNeighborCount++;
        //        }
        //        else
        //        {
        //            if (boardState[row - 1, col + 1] == true)
        //                diagonalNeighborCount++;
        //            if (boardState[row + 1, col + 1] == true)
        //                diagonalNeighborCount++;

        //        }
        //    }
        //    else if (col == _lastColumn)
        //    {
        //        if (row == 0)
        //        {
        //            if (boardState[row + 1, col - 1])
        //                diagonalNeighborCount++;
        //        }
        //        else if (row == _lastRow)
        //        {
        //            if (boardState[row - 1, col - 1] == true)
        //                diagonalNeighborCount++;
        //        }
        //        else
        //        {
        //            if (boardState[row - 1, col - 1] == true)
        //                diagonalNeighborCount++;
        //            if (boardState[row + 1, col - 1] == true)
        //                diagonalNeighborCount++;
        //        }
        //    }
        //    else if (row == 0)
        //    {

        //        if (boardState[row + 1, col + 1] == true)
        //            diagonalNeighborCount++;
        //        if (boardState[row + 1, col - 1] == true)
        //            diagonalNeighborCount++;
        //    }
        //    else if (row == _lastRow)
        //    {
        //        if (boardState[row - 1, col - 1] == true)
        //            diagonalNeighborCount++;
        //        if (boardState[row - 1, col + 1] == true)
        //            diagonalNeighborCount++;
        //    }
        //    else
        //    {
        //        // diag left
        //        if (boardState[row - 1, col - 1] == true)
        //            diagonalNeighborCount++;
        //        if (boardState[row + 1, col + 1] == true)
        //            diagonalNeighborCount++;

        //        // diag right
        //        if (boardState[row - 1, col + 1] == true)
        //            diagonalNeighborCount++;
        //        if (boardState[row + 1, col - 1] == true)
        //            diagonalNeighborCount++;
        //    }

        //    return diagonalNeighborCount;
        //}

        //public int CountActiveNeighborsOfCell(int row, int col)
        //{
        //    int vertical = CountVerticalNeighborsOfCell(row, col);
        //    int horizontal = CountHorizontalNeighborsOfCell(row, col);
        //    int diagonal = CountDiagonalNeighorsOfCell(row, col);

        //    neighborCount = vertical + horizontal + diagonal;

        //    return neighborCount;
        //}


        public static bool HasVerticalWin(Colors[,] board, int row, int col)
        {
            Colors state = board[row, col];

            if (board[row - 1, col] == state && board[row - 2, col] == state && board[row - 3, col] == state)
                return true;
            else
                return false;

        }

        public static bool HasHorizontalWin(Colors[,] board, int row, int col)
        {
            Colors state = board[row, col];

            if (col > 2)
            {
                if (board[row, col - 1] == state && board[row, col - 2] == state && board[row, col - 3] == state)
                    return true;
            }

            return false;
        }

        public static bool HasDiagonalWin(Colors[,] board, int row, int col)
        {
            Colors state = board[row, col];

            if (col <= 2 && row > 2)
            {
                if (board[row - 1, col + 1] == state && board[row - 2, col + 2] == state && board[row - 3, col + 3] == state)
                    return true;
            }
            else if (col >= 3 && row > 2)
            {
                if (board[row - 1, col - 1] == state && board[row - 2, col - 2] == state && board[row - 3, col - 3] == state)
                    return true;
            }
            else if (row)

            return false;

            //    int diagonalNeighborCount = 0;
            //    int lastColumn = board.GetLength(0);
            //    int lastRow = board.GetLength(1);

            //    if (col == 0)
            //    {
            //        if (row == 0)
            //        {
            //            if (board[row + 1, col + 1] == state)
            //                diagonalNeighborCount++;
            //        }
            //        else if (row == lastRow)
            //        {
            //            if (board[row - 1, col + 1] == state)
            //                diagonalNeighborCount++;
            //        }
            //        else
            //        {
            //            if (board[row - 1, col + 1] == state)
            //                diagonalNeighborCount++;
            //            if (board[row + 1, col + 1] == state)
            //                diagonalNeighborCount++;

            //        }
            //    }
            //    else if (col == lastColumn)
            //    {
            //        if (row == 0)
            //        {
            //            if (board[row + 1, col - 1] == state)
            //                diagonalNeighborCount++;
            //        }
            //        else if (row == lastRow)
            //        {
            //            if (board[row - 1, col - 1] == state)
            //                diagonalNeighborCount++;
            //        }
            //        else
            //        {
            //            if (board[row - 1, col - 1] == state)
            //                diagonalNeighborCount++;
            //            if (board[row + 1, col - 1] == state)
            //                diagonalNeighborCount++;
            //        }
            //    }
            //    else if (row == 0)
            //    {

            //        if (board[row + 1, col + 1] == state)
            //            diagonalNeighborCount++;
            //        if (board[row + 1, col - 1] == state)
            //            diagonalNeighborCount++;
            //    }
            //    else if (row == lastRow)
            //    {
            //        if (board[row - 1, col - 1] == state)
            //            diagonalNeighborCount++;
            //        if (board[row - 1, col + 1] == state)
            //            diagonalNeighborCount++;
            //    }
            //    else
            //    {
            //        // diag left
            //        if (board[row - 1, col - 1] == state)
            //            diagonalNeighborCount++;
            //        if (board[row + 1, col + 1] == state)
            //            diagonalNeighborCount++;

            //        // diag right
            //        if (board[row - 1, col + 1] == state)
            //            diagonalNeighborCount++;
            //        if (board[row + 1, col - 1] == state)
            //            diagonalNeighborCount++;
            //    }


            //return (diagonalNeighborCount >= 4) ? true : false;

        }
    }
}
