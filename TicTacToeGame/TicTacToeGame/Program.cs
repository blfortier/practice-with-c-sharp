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
            //Dictionary<int, string> board = new Dictionary<int, string>()
            //        {
            //            {1, " "},
            //            {2, " "},
            //            {3, " "},
            //            {4, " "},
            //            {5, " "},
            //            {6, " "},
            //            {7, " "},
            //            {8, " "},
            //            {9, " "}
            //        };

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

        public static void ImportBoard(string[] moves, Dictionary<int, string> places)
        {
            List<int> player1Moves = new List<int>();
            List<int> player2Moves = new List<int>();

            for (var i = 0; i < moves.Length; i++)
            {
                places[i + 1] = moves[i];

                //if (i % 2 == 0)
                //    player1Moves.Add(places.Keys)

            }

            foreach (KeyValuePair<int, string> item in places)
                Console.WriteLine("Cell: {0}, Token: {1} ", item.Key, item.Value);

        }

        public static void DisplayBoard()
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
