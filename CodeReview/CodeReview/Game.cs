using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeReview
{
    class Game
    {
        protected char player1;
        protected char player2;
        protected char currentToken;
        protected char winner;
        private int moveCount = 0;
        public Board gameBoard;

        public Game(char player1, char player2, int rows, int columns)
        {
            this.player1 = player1;
            this.player2 = player2;
            this.winner = ' ';
            this.gameBoard = new Board(rows, columns);
        }

        private bool CheckMoveValidity(int move)
        {
            return (move < 0 || move > gameBoard.columns);
        }

        public void ApplyMove(int move)
        {
            if (moveCount % 2 != 1)
                currentToken = player1;
            else
                currentToken = player2;

            if (CheckMoveValidity(move))
                Console.WriteLine("Not a valid move..");
            else
            {
                if (gameBoard.board[gameBoard.rows - 1, move] == ' ')
                {
                    gameBoard.board[gameBoard.rows - 1, move] = currentToken;
                    moveCount++;
                }
            }
        }
    }
}
