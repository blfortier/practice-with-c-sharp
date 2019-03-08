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
            protected string[] board;
            protected string player1Token;
            protected List<int> player1Moves ;
            protected string player2Token;
            protected List<int> player2Moves;
            protected string winner;
            protected string currentToken;
            private int moveCount = 0;

            public TicTacToe(string player1, string player2)
            {
                this.player1Token = player1;
                this.player2Token = player2;
                this.winner = " ";
                this.board = SetBoard();
            }

            private static string[] SetBoard()
            {
                string[] board = new string[9];
                for (int i = 0; i < board.Length; i++)
                    board[i] = " ";

                return board;
            }

            public bool IsValidMove(int cell)
            {
                bool isValid = WithinRange(cell) && !CellTaken(cell);
             
                return isValid;
            }

            public bool ApplyMove(int cell)
            {
                if (IsValidMove(cell))
                {
                    board[cell - 1] = currentToken;
                    moveCount++; 

                    if (currentToken == player1Token)
                        player1Moves.Add(cell);
                    else
                        player2Moves.Add(cell);

                    currentToken = (currentToken == player1Token) ? player2Token : player1Token;
                }

             
                return true;
            }

            private void ProcessMove(int cell)
            {
                if (!IsValidMove(cell))
                    return;
                else
                {
                    ApplyMove(cell);
                    IsGameOver();
                }
            }

            private void IsGameOver()
            {
                if (IsDraw())
                {
                    Console.WriteLine("Looks like the board is full, nobody one. Draw!");
                    ResetBoard();
                }
                else if (IsAWin())
                {
                    Console.WriteLine("We've got a winner!");
                    ResetBoard();
                }
            }

            private void ResetBoard()
            {
                var newGame = new TicTacToe("O", "X");
            }

            private bool IsDraw()
            {
                return moveCount > 9;
            }

            private bool CellTaken(int cell)
            {
                return board[cell - 1] != " ";
            }

            private bool WithinRange(int cell)
            {
                return cell > 0 && cell < board.Length + 1;
            }

            public void DisplayBoard()
            {
                var topAndBottom = "     |     |    ";
                var connector = "     |     |    \n-----+-----+-----\n     |     |    ";

                Console.WriteLine();
                Console.WriteLine(topAndBottom);
                Console.WriteLine("  {0}  |  {1}  |  {2}", board[0], board[1], board[2]);
                Console.WriteLine(connector);
                Console.WriteLine("  {0}  |  {1}  | {2}  ", board[3], board[4], board[5]);
                Console.WriteLine(connector);
                Console.WriteLine("  {0}  |  {1}  | {2}  ", board[6], board[7], board[8]);
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
              var arrayOfBoardMoves = (importedBoard.Split(','));

                for (var j = 0; j < board.Length; j++)
                    this.board[j] = arrayOfBoardMoves[j]; 

                for (var i = 0; i < board.Length + 1; i++)
                {
                    Console.WriteLine("{0} : {1}", i, arrayOfBoardMoves[i]);
                }
            }


            public bool IsAWin()
            {
                bool DiagonalsAndMiddles =
                    FirstDiagonal() || SecondDiagonal() || SecondRow() || SecondColumn() && board[4] != " ";
                bool FirstRowAndColumn = FirstRow() || FirstColumn() && board[0] != " ";
                bool ThirdRowAndColumn = ThirdRow() || ThirdColumn() && board[8] != " ";

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
            var game = new TicTacToe("X", "O");
            Console.WriteLine("Board");
            game.DisplayBoard();

            //var play = "X, X, O, O, X, O, X, O, X, O";
            //game.ImportBoard(play);
            //game.DisplayBoard();

            Console.WriteLine(game.IsAWin());



            // game.DisplayHelpBoard();
        }
    }

}
