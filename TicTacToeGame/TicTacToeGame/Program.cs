using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace TicTacToeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> board = new Dictionary<int, string>()
            {
                {1, " "},
                {2, " "},
                {3, " "},
                {4, " "},
                {5, " "},
                {6, " "},
                {7, " "},
                {8, " "},
                {9, " "}
            };
          

            DisplayBoard(board);

            var moveCount = 0;
            var import = new[] {"X", "X", "O", "X", "O", "O", "X", "O", "X"};

            ImportBoard(import, board);

            // Console.WriteLine(board[7]);
            // if(board.Contains(new KeyValuePair<int, string>(4, null)))
            //      Console.WriteLine("Sorry, that spot is taken. Try another cell.");             
            //  board[4] = "X";
            //  Console.WriteLine(board[4]);     

        }

        public static void ImportBoard(string[] moves, Dictionary<int, string> board)
        {
            List<int> player1Moves = new List<int>();
            List<int> player2Moves = new List<int>();

            for (var i = 0; i < moves.Length; i++)
            {
                board[i + 1] = moves[i];

                if (i % 2 == 0)
                    player1Moves.Add(Array.IndexOf(moves, moves[i]));
                else
                    player2Moves.Add(Array.IndexOf(moves, moves[i]));
            }

            foreach (KeyValuePair<int, string> item in board)
                Console.WriteLine("Cell: {0}, Token: {1} ", item.Key, item.Value);

            foreach (var move in player1Moves)
                Console.WriteLine("Player 1 moves: {0}", player1Moves);

            foreach (var move in player2Moves)
                Console.WriteLine("Player 2 moves: {0}", player2Moves);



        }

        public static void DisplayBoard(Dictionary<int, string> board)
        {
            var topAndBottom = "     |     |    ";
            var connector = "     |     |    \n-----+-----+-----\n     |     |    ";

            Console.WriteLine();
            Console.WriteLine(topAndBottom);
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[1], board[2], board[3]);
            Console.WriteLine(connector);
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[4], board[5], board[6]);
            Console.WriteLine(connector);
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[7], board[8], board[9]);
            Console.WriteLine(topAndBottom);

            Console.WriteLine();
        }
    }
}
