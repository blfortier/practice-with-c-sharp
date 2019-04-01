using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeReview
{
    class StartGame
    {
        protected string player1Token;
        protected string player2Token;
        protected string currentToken;
        protected string winner;
        private int moveCount;

        public StartGame(string player1, string player2, int row, int col)
        {
            this.player1Token = player1;
            this.player2Token = player2;
            this.winner = " ";
            DrawDynamicBoard.DrawBoard(row, col);
        }

        public static bool IsHeightAndWidthValid(int height, int width)
        {
            return height > 2 && height < 30 && width > 2 && width < 30;
        }

    }
}
