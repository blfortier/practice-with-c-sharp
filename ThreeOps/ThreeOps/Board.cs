using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeOps
{
    public class Board
    {
        private int _rows { get; set; }
        private int _columns { get; set; }
        

        public Board(int rows, int columns)
        {
            this._rows = rows;
            this._columns = columns;
           // Game game = new Game(6, 6);

            Board[,] board = new Board[_rows, _columns];
        }

        public void DisplayBoard(string[,] gameBoard)
        {
                                  
            for (int row = 0; row < _rows; row++)
            {
                string row1 = "| ";
                string row2 = "";

                for (int col = 0; col < _columns; col++)
                {
                    row1 = row1 + gameBoard[row, col] + " | ";
                    row2 += "+------";
                }
                Console.WriteLine(row1);
                Console.WriteLine(row2 + "+");
            }
        }

        public string CheckCellState(Game game, int row, int col)
        {
            return game.board[row, col];

        }

        public string[,] CheckTopRow(Game game, Board board)
        {
            for (int r = 0; r <= 1; r++)
            {
                for (int c = 0; c <=1; c++)
                {
                    if (game.board[r, c] == "red")
                        break;
                }
            }
            return game.board;
        }

        //public string CheckForEmptyBoard(Colors[,] board)
        //{

        //    for (int row = 0; row < _rows; row++)
        //    {
        //        for (int col = 0; col < _columns; col++)
        //        {
        //            if (board[row, col] != Colors.Gray)
        //                return "Board is not empty.";
        //        }
        //    }
        //    return "Board is empty";

        //}

        public string[,] SwitchLeftColumn(Game game, Board board)
        {
            for (int r = 0; r < board._rows; r++)
            {
                for (int c = 0; ; c++)
                {
                    if (game.board[r, c] == "red")
                        break;
                }
            }
            return game.board;
        }

        public string CheckBoardForVerticalWin(Game game, Board board)
        {
    
            for (int col = 0; col < board._columns; col++)
            {
                for (int row = board._rows - 1; row <= 2; row--)
                {
                    //Console.WriteLine("r:{0} c:{1}", row, col);
                    if (game.board[row, col] == "red")
                    {
                        Console.WriteLine("r:{0} c:{1}", row, col);

                        if (game.board[row - 1, col] != "red" || game.board[row - 2, col] != "red" || game.board[row - 3, col] != "red")
                        {
                            Console.WriteLine(game.board[row - 3, col]);
                            return "Not a winner";
                        }
                    }
                }
            }

            return "You are a winner.";
        }
    }

}
