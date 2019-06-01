using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace GameOfLife.UnitTests
{
    [TestFixture]
    public class GoLTests
    {
        private GameBoard _gameBoard;
        int row, column;

        [SetUp]
        public void TestFixtureSetup()
        {
            _gameBoard = new GameBoard();
        }

        [Test]
        public void EnterRowAndColumn_ReturnStateOfCell()
        {
            row = 2;
            column = 4;

            var expected = false;
            var actual = _gameBoard.GetStateOfSpecificCell(row, column);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IfStateOfCellIsFalse_SwitchToTrue()
        {
            row = 2;
            column = 4;

            var expected = true;
            var actual = _gameBoard.SwitchStateOfCell(row, column);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IfStateOfCellIsTrue_SwitchToFalse()
        {
            row = 5;
            column = 7;
            _gameBoard.boardState[row, column] = true;

            var expected = false;
            var actual = _gameBoard.SwitchStateOfCell(row, column);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckActiveCellForVerticalNeightbors_ReturnCountOfVerticalNeighbors()
        {
            _gameBoard.SwitchStateOfCell(3, 5);
            _gameBoard.SwitchStateOfCell(2, 5);

            var expected = 1;
            var actual = _gameBoard.CountAllVerticalNeighborsOfActiveCell(3, 5);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckActiveCellForHorizontalNeightbors_ReturnCountOfHorizontalNeighbors()
        {
            _gameBoard.SwitchStateOfCell(3, 5);
            _gameBoard.SwitchStateOfCell(3, 6);
            _gameBoard.SwitchStateOfCell(3, 4);

            var expected = 2;
            var actual = _gameBoard.CountAllHorizontalNeighborsOfActiveCell(3, 5);

            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void CheckActiveCellForVerticalNeightbors_ReturnCountOfNeighbors()
        {
            _gameBoard.SwitchStateOfCell(3, 5);
            _gameBoard.SwitchStateOfCell(3, 6);
            _gameBoard.SwitchStateOfCell(3, 4);

            var expected = 2;
            var actual = _gameBoard.CountAllVerticalNeighborsOfActiveCell(3, 5);

            Assert.AreEqual(expected, actual);
        }


        //[Test]
        //public void CheckActiveCellForDiagonalLeftNeightbors_ReturnCountOfNeighbors()
        //{
        //    _gameBoard.SwitchStateOfCell(3, 5);
        //    _gameBoard.SwitchStateOfCell(2, 4);
        //    _gameBoard.SwitchStateOfCell(4, 6);

        //    var expected = 2;
        //    var actual = _gameBoard.CountActiveNeightborsOfActiveCell(3, 5);

        //    Assert.AreEqual(expected, actual);
        //}

        //[Test]
        //public void CheckActiveCellForDiagonallRightNeightbors_ReturnCountOfNeighbors()
        //{
        //    _gameBoard.SwitchStateOfCell(3, 5);
        //    _gameBoard.SwitchStateOfCell(4, 4);
        //    _gameBoard.SwitchStateOfCell(2, 6);

        //    var expected = 2;
        //    var actual = _gameBoard.CountActiveNeightborsOfActiveCell(3, 5);

        //    Assert.AreEqual(expected, actual);
        //}

        //[Test]
        //public void CheckActiveCellForAnyActiveNeightbors_ReturnCountOfNeighbors()
        //{
        //    _gameBoard.SwitchStateOfCell(3, 5);
        //    _gameBoard.SwitchStateOfCell(4, 4);
        //    _gameBoard.SwitchStateOfCell(2, 6);
        //    _gameBoard.SwitchStateOfCell(2, 4);
        //    _gameBoard.SwitchStateOfCell(4, 6);
        //    _gameBoard.SwitchStateOfCell(3, 6);
        //    _gameBoard.SwitchStateOfCell(3, 4);
        //    _gameBoard.SwitchStateOfCell(2, 5);

        //    var expected = 7;
        //    var actual = _gameBoard.CountActiveNeightborsOfActiveCell(3, 5);

        //    Assert.AreEqual(expected, actual);
        //}

        //[Test]
        //public void GetCountOfActiveNeightborsOfActiveCellOnEdgeOfBoard_ReturnCount()
        //{
        //    _gameBoard.SwitchStateOfCell(6, 0);
        //    _gameBoard.SwitchStateOfCell(5, 1);

        //    var expected = 1;
        //    var actual = _gameBoard.CountActiveNeightborsOfActiveCell(6, 0);

        //    Assert.AreEqual(expected, actual);

        //}

        //[Test]
        //public void CheckBoardForActiveCells_ReturnListOfActiveCells()
        //{
        //    _gameBoard.SwitchStateOfCell(6, 5);
        //    _gameBoard.SwitchStateOfCell(2, 10);
        //    _gameBoard.SwitchStateOfCell(13, 7);

        //    List<int> returnedBoard = new List<int> { 6, 5, 2, 10, 13, 7 };

        //    var expected = returnedBoard;
        //    var actual = _gameBoard.GetAllActiveCellsInBoard();
        //    Assert.AreEqual(expected, actual);

        //}


        //    [Test]
        //    public void CheckBoardForOneActiveCell_ReturnIndexOfActiveCell()
        //    {
        //        _gameBoard.SwitchStateOfCell(3, 5);

        //        List<int> returnedBoard = new List<int> { 3, 5};

        //        var expected = returnedBoard;
        //        var actual = _gameBoard.GetAllActiveCellsInBoard();
        //        Assert.AreEqual(expected, actual);

        //    }

    }
}

/*
For a space that is 'populated':
    Each cell with one or no neighbors dies, as if by solitude.
    Each cell with four or more neighbors dies, as if by overpopulation.
    Each cell with two or three neighbors survives.
For a space that is 'empty' or 'unpopulated'
    Each cell with three neighbors becomes populated.      
*/
