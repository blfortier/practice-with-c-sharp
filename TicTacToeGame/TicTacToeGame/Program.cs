﻿using System;
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
            string[] board = {"0", "1" , "2", "3", "4", "5", "6", "7", "8"};

            foreach (var num in board)
            {
                Console.WriteLine(num);
            }

        }
    }
}
