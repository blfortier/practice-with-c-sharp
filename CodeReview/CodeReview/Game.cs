using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConnectFour
{
    class Game
    {
        private char _player1;
        private char _player2;
        private char _currentToken;
        private char _winner;
        private int moveCount = 0;
        public Board gameBoard;

        public char Player1 { get => _player1; set => _player1 = value; }
        public char Player2 { get => _player2; set => _player2 = value; }

        public Game(char player1, char player2, int rows, int columns)
        {
            this.Player1 = player1;
            this.Player2 = player2;
            this._winner = ' ';
            this.gameBoard = new Board(rows, columns);
        }

        public void ApplyMove(int colToAddMove)
        {
            _currentToken = (moveCount % 2 != 1) ? Player1 : Player2;

            for (int rowBeingChecked = gameBoard.rows - 1; rowBeingChecked >= 0; rowBeingChecked--)
            {
                if (gameBoard.board[0, colToAddMove] != ' ')
                {
                    Console.WriteLine("Sorry, that column is full...");
                    break;
                }
                else if (gameBoard.board[rowBeingChecked, colToAddMove] == ' ')
                {
                    gameBoard.board[rowBeingChecked, colToAddMove] = _currentToken;
                    moveCount++;
                    //  Console.WriteLine("moveCount: {0}", moveCount);
                    break;
                }
            }            
        }
    }
}
