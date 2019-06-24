using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConnectFour.Board;

namespace ConnectFour.UnitTests
{

    [TestFixture]
    public class ConnectFourTests
    {
        public Colors[,] _board;
        public int Rows = 6;
        public int Columns = 7;

        Colors Gray = Colors.Gray;
        Colors Red = Colors.Red;
        Colors Blue = Colors.Blue;

        [Test]
        public void GetStateOfOneCell()
        {
            _board = new Colors[Rows, Columns];
            _board[4, 5] = Blue;
            _board[0, 0] = Red;

            DisplayBoard(_board);

            var expected = Blue;
            var actual = GetStateOfCell(_board, 4, 5);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckACellForOneNeighborAbove()
        {
            _board = new Colors[Rows, Columns];
            _board[3, 2] = Blue;
            _board[4, 2] = Blue;

            DisplayBoard(_board);

            var expected = true;
            var actual = CheckCellForNeighborsAbove(_board);

            Assert.AreEqual(expected, actual);
        }

        //[Test]
        //public void CheckACellForOneNeighborBelow()
        //{
        //    _board = new Colors[Rows, Columns];
        //    _board[3, 2] = Blue;
        //    _board[2, 2] = Blue;

        //    DisplayBoard(_board);

        //    var expected = true;
        //    var actual = CheckCellForNeighborsAbove(_board);

        //    Assert.AreEqual(expected, actual);
        //}


        [Test]
        public void CheckACellForOneNeighborToTheRight()
        {
            _board = new Colors[Rows, Columns];
            _board[3, 2] = Blue;
            _board[3, 3] = Blue;

            DisplayBoard(_board);

            var expected = true;
            var actual = CheckCellForNeighborsToRight(_board);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckACellForOneNeighborToTheLeft()
        {
            _board = new Colors[Rows, Columns];
            _board[1, 4] = Blue;
            _board[1, 3] = Blue;

            DisplayBoard(_board);

            var expected = true;
            var actual = CheckCellForNeighborsToLeft(_board);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckACellForOneNeighborToLeftDiagUpper()
        {
            _board = new Colors[Rows, Columns];
            _board[2, 2] = Blue;
            _board[1, 1] = Blue;

            DisplayBoard(_board);

            var expected = true;
            var actual = CheckCellForNeighborsToLeftDiagUpper(_board);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SeeIfThereIsAVerticalWinFromBottomOfGrid()
        {
            _board = new Colors[Rows, Columns];
            _board[5, 2] = Blue;
            _board[4, 2] = Blue;
            _board[3, 2] = Blue;
            _board[2, 2] = Blue;

            DisplayBoard(_board);

            var expected = true;
            var actual = HasVerticalWin(_board, 5, 2);

            Assert.AreEqual(expected, actual);

        }


        [Test]
        public void SeeIfThereIsAVerticalWinFromBottomSecondToLastRowOfGrid()
        {
            _board = new Colors[Rows, Columns];
            _board[4, 2] = Red;
            _board[2, 2] = Red;
            _board[3, 2] = Red;
            _board[1, 2] = Red;

            DisplayBoard(_board);

            var expected = true;
            var actual = HasVerticalWin(_board, 4, 2);

            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void CheckForAHorizontalWinFromBottomOfGrid()
        {
            _board = new Colors[Rows, Columns];
            _board[5, 3] = Red;
            _board[5, 2] = Red;
            _board[5, 1] = Red;
            _board[5, 0] = Red;

            DisplayBoard(_board);

            var expected = true;
            var actual = HasHorizontalWin(_board, 5, 3);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void WhenTheColumnIsTwoOrLess_DoNotCheckForHoriZontalWin()
        {
            _board = new Colors[Rows, Columns];
            _board[5, 2] = Red;
            _board[5, 1] = Red;
            _board[5, 0] = Red;

            DisplayBoard(_board);

            var expected = false;
            var actual = HasHorizontalWin(_board, 5, 2);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void WhenTheRowIsTwoOrLess_DoNotCheckForVerticalWin()
        {
            _board = new Colors[Rows, Columns];
            _board[5, 2] = Red;
            _board[5, 1] = Red;
            _board[5, 0] = Red;

            DisplayBoard(_board);

            var expected = false;
            var actual = HasHorizontalWin(_board, 5, 2);

            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void WhenTheColumnIsThreeAwayFromRightEdgeOfBoard_DoNotCheckForDiagonalRightWin()
        {
            _board = new Colors[Rows, Columns];
            _board[5, 3] = Blue;
            _board[4, 4] = Blue;
            _board[3, 5] = Blue;

            DisplayBoard(_board);

            var expected = false;
            var actual = HasDiagonalWin(_board, 5, 2);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CheckForDiagonalWin()
        {
            _board = new Colors[Rows, Columns];
            _board[4, 2] = Red;
            _board[3, 3] = Red;
            _board[2, 4] = Red;
            _board[1, 5] = Red;

            DisplayBoard(_board);

            var expected = true;
            var actual = HasDiagonalWin(_board, 4, 2);

            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void CheckACellForOneNeighborToRightDiagUpper()
        {
            _board = new Colors[Rows, Columns];
            _board[3, 2] = Red;
            _board[2, 3] = Red;

            DisplayBoard(_board);

            var expected = true;
            var actual = CheckCellForNeighborsToRightDiagUpper(_board);

            Assert.AreEqual(expected, actual);
        }






        //[Test]
        //public void CheckACellForOneNeighborToRightDiagLower()
        //{
        //    _board = new Colors[Rows, Columns];
        //    _board[3, 2] = Red;
        //    _board[4, 3] = Red;

        //    DisplayBoard(_board);

        //    var expected = true;
        //    var actual = CheckCellForNeighborsToRightDiagLower(_board);

        //    Assert.AreEqual(expected, actual);
        //}

        //[Test]
        //public void CheckACellForOneNeighborToLeftDiagLower()
        //{
        //    _board = new Colors[Rows, Columns];
        //    _board[2, 2] = Red;
        //    _board[3, 1] = Red;

        //    DisplayBoard(_board);

        //    var expected = true;
        //    var actual = CheckCellForNeighborsToLeftDiagLower(_board);

        //    Assert.AreEqual(expected, actual);
        //}

    }
}