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
        public Colors[,] _board = new Colors[6, 6];

        Colors Gray = Colors.Gray;
        Colors Red = Colors.Red;
        Colors Blue = Colors.Blue;


        [Test]
        public void CheckACellForOneNeighborToTheRight()
        {
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
            _board[2, 2] = Blue;
            _board[1, 1] = Blue;

            DisplayBoard(_board);

            var expected = true;
            var actual = CheckCellForNeighborsToLeftDiagUpper(_board);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckACellForOneNeighborToLeftDiagLower()
        {
            _board[2, 2] = Red;
            _board[3, 1] = Red;

            DisplayBoard(_board);

            var expected = true;
            var actual = CheckCellForNeighborsToLeftDiagLower(_board);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckACellForOneNeighborToRightDiagUpper()
        {
            _board[3, 2] = Red;
            _board[2, 3] = Red;

            DisplayBoard(_board);

            var expected = true;
            var actual = CheckCellForNeighborsToRightDiagUpper(_board);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckACellForOneNeighborToRightDiagLower()
        {
            _board[3, 2] = Red;
            _board[4, 3] = Red;

            DisplayBoard(_board);

            var expected = true;
            var actual = CheckCellForNeighborsToRightDiagLower(_board);

            Assert.AreEqual(expected, actual);
        }
    }
}