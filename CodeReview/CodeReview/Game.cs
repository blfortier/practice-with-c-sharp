using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeReview
{
    class Game
    {
        protected string player1Token;
        protected string player2Token;
        protected string currentToken;
        protected string winner;
        private int moveCount;
        public string[,] board;

        public Game(string player1, string player2, int row, int col)
        {
            this.player1Token = player1;
            this.player2Token = player2;
            this.winner = " ";
            this.moveCount = 0;
            this.board = SetBoard(row, col);
           // Board.DrawBoard(row, col);
        }

        public string[,] SetBoard(int row, int col)
        {
            string[,] board = new string[row, col];

            for (int rows = 0; rows < row; rows++)
            {
                for (int columns = 0; columns < col; columns++)
                {
                    board[rows, columns] = " ";
                }
            }

            return board;
        }

    }
}
