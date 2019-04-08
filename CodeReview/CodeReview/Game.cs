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

        public void ApplyMove(int rowToMove, int colToAddMove)
        {
            _currentToken = (moveCount % 2 != 1) ? Player1 : Player2;
            
            gameBoard.board[rowToMove - 1, colToAddMove - 1] = _currentToken;
            moveCount++;
        }
    }
}
