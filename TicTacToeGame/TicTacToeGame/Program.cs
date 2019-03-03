using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace TicTacToeGame
{
    class Program
    {
        class TicTacToe
        {
            protected char[] board;
            protected char player1Token;
            protected int[] player1Moves;
            protected char player2Token;
            protected int[] player2Moves;
            protected char winner;
            protected char currentToken;
            private int moveCount = 0;

            public TicTacToe(char player1, char player2)
            {
                this.player1Token = player1;
                this.player2Token = player2;
                this.winner = ' ';
                this.board = SetBoard();
            }

            private static char[] SetBoard()
            {
                char[] board = new char[9];
                for (int i = 0; i < board.Length; i++)
                    board[i] = ' ';

                return board;
            }

            public bool IsValidMove(int cell)
            {
                bool isValid = WithinBoard(cell) && !CellTaken(cell);

                if (isValid)
                {
                    board[cell - 1] = currentToken;
                    currentToken = (currentToken == player1Token) ? player2Token : player1Token;
                }

                return isValid;
            }

            private bool CellTaken(int cell)
            {
                return board[cell - 1] != ' ';
            }

            private bool WithinBoard(int cell)
            {
                return cell > 0 && cell < board.Length + 1;
            }

            public void DisplayBoard()
            {
                var topAndBottom = "     |     |    ";
                var connector = "     |     |    \n-----+-----+-----\n     |     |    ";

                Console.WriteLine();
                Console.WriteLine(topAndBottom);
                Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[0], board[1], board[2]);
                Console.WriteLine(connector);
                Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[3], board[4], board[5]);
                Console.WriteLine(connector);
                Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[6], board[7], board[8]);
                Console.WriteLine(topAndBottom);
                Console.WriteLine();
            }

            public void DisplayHelpBoard()
            {
                var topAndBottom = "     |     |    ";
                var connector = "     |     |    \n-----+-----+-----\n     |     |    ";

                Console.WriteLine();
                Console.WriteLine(topAndBottom);
                Console.WriteLine("  1  |  2  |  3  ");
                Console.WriteLine(connector);
                Console.WriteLine("  4  |  5  |  6  ");
                Console.WriteLine(connector);
                Console.WriteLine("  7  |  8  |  9  ");
                Console.WriteLine(topAndBottom);
                Console.WriteLine();

            }

            public void ImportBoard(string importedBoard)
            {
              //  var arrayOfBoardMoves = (importedBoard.Split(','));
              //char[] arrayOfBoardMoves = importedBoard.Trim().ToCharArray();

            foreach (var VARIABLE in importedBoard.Split(' '))
                {
                    Console.WriteLine(VARIABLE);   
                }

                for (var i = 0; i < board.Length; i++)
                {
                   // this.board[i] = arrayOfBoardMoves[i];
                }
            }


            public bool IsThereAWin()
            {
                bool DiagonalsAndMiddles =
                    FirstDiagonal() || SecondDiagonal() || SecondRow() || SecondColumn() && board[4] != ' ';
                bool FirstRowAndColumn = FirstRow() || FirstColumn() && board[0] != ' ';
                bool ThirdRowAndColumn = ThirdRow() || ThirdColumn() && board[8] != ' ';

                if (DiagonalsAndMiddles)
                    this.winner = board[4];
                else if (FirstRowAndColumn)
                    this.winner = board[0];
                else if (ThirdRowAndColumn)
                    this.winner = board[8];

                return DiagonalsAndMiddles || FirstRowAndColumn || ThirdRowAndColumn;
            }

          
            private bool FirstDiagonal()
            {
                return board[0] == board[4] && board[4] == board[8];
            }

            private bool SecondDiagonal()
            {
                return board[2] == board[4] && board[4] == board[6];
            }


            private bool SecondColumn()
            {
                return board[1] == board[4] && board[4] == board[7];
            }

            private bool SecondRow()
            {
                return board[3] == board[4] && board[4] == board[5];
            }

            private bool FirstRow()
            {
                return board[0] == board[1] && board[1] == board[2];
            }

            private bool FirstColumn()
            {
                return board[0] == board[3] && board[3] == board[6];
            }

            private bool ThirdColumn()
            {
                return board[2] == board[5] && board[5] == board[8];
            }

            private bool ThirdRow()
            {
                return board[6] == board[7] && board[7] == board[8];
            }
        }   

        static void Main(string[] args)
        {
            var game = new TicTacToe('O', 'X');
            Console.WriteLine("Board");
            game.DisplayBoard();
            
            var play = "X, X, O, O, X, O, X, O, X";
            game.ImportBoard(play);
            game.DisplayBoard();



            // game.DisplayHelpBoard();
        }
    }

}
