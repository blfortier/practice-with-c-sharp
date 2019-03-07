using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTesting
{
    class TicTacTests
    {
    }

    [TestFixture]
    public class TicTacToeTests
    {
        [Test]
        public void CreateGame_ZeroMoves()
        {
            var game = new Game();
            Assert.AreEqual(0, game.MovesCounter);
        }

        [Test]
        public void MakeMove_IncreaseCounter()
        {
            var game = new Game();
            game.MakeMove(1);

            Assert.AreEqual(1, game.MovesCounter);
        }

    }

    public class Game
    {
        public int MovesCounter { get; private set; } 
        
        public void MakeMove(int move)
        {
            MovesCounter++;
        }
    }



}
