using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeOps
{
    public class Game
    {
        public string[,] board;
        public Game(int r, int c)
        {
            this.board = new string[6,6];

            for (int row = 0; row < 6; row++)
            {
                for (int col = 0; col < 6; col++)
                {
                    board[row, col] = "gray";
                }
            }
        }
    }

    public enum Colors
    {
        Gray,
        Red,
        Blue,
    }
}
