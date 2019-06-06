using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeOps
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(6, 6);
            Game game = new Game(6, 6);
            board.DisplayBoard(game.board);
        }
    }
}
