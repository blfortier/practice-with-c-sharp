using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeOps;


namespace ThreeOps.Tests
{
    [TestFixture]
    public class ThreeOpsTest
    {
           
      //  public Board _board = new Board(6, 6);
        // private Colors[,] board;
        public int Rows = 6;
        public int Columns = 6;

        [SetUp]
        public void TestSetUp()
        {
        }

   // [Test]
      //  public void CheckForEmptyBoard_ReturnString()
        //{

        //    var expected = "Board is empty.";
        //    string actual = _board.CheckForEmptyBoard(_board);
        //}

        [Test]
        public void SwitchOneCellToBlue()
        {
            Board board = new Board(6, 6);
            Game game = new Game(6, 6);

            game.board[0,0] = "blue";
            board.DisplayBoard(game.board);

            var expected = "blue";
            var actual = board.CheckCellState(game, 0, 0);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SwitchTopRowToRed()
        {
            Board board = new Board(6, 6);
            Game game = new Game(6, 6);

            game.board[0, 0] = "red";
            game.board[0, 1] = "red";
            game.board[0, 2] = "red";
            game.board[0, 3] = "red";
            game.board[0, 4] = "red";
            game.board[0, 5] = "red";

            board.DisplayBoard(game.board);

            string[,] expected = game.board;
            var actual = board.CheckTopRow(game, board);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SwitchLeftColumnToRed()
        {
            Board board = new Board(6, 6);
            Game game = new Game(6, 6);

            game.board[0, 0] = "red";
            game.board[1, 0] = "red";
            game.board[2, 0] = "red";
            game.board[3, 0] = "red";
            game.board[4, 0] = "red";
            game.board[5, 0] = "red";

            board.DisplayBoard(game.board);

            string[,] expected = game.board;
            var actual = board.CheckTopRow(game, board);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckBoardForVerticalWin()
        {
            Board board = new Board(6, 6);
            Game game = new Game(6, 6);

            game.board[2, 0] = "red";
            game.board[3, 0] = "red";
            game.board[4, 0] = "red";
            game.board[5, 0] = "red";

            board.DisplayBoard(game.board);

            var expected = "You are a winner.";
            var actual = board.CheckBoardForVerticalWin(game, board);

            Assert.AreEqual(expected, actual);
        }
    }
}
