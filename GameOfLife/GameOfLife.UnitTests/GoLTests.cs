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

        [SetUp]
        public void TestFixtureSetup()
        {
            _gameBoard = new GameBoard();
            _gameBoard.SetInitialState();
        }

        [Test]
        public void InsertCharIntoOneCellOfBoard()
        {
            int row = 1; 
            int col = 2;

            var expected = 'X';
            var actual = _gameBoard.InsertCharIntoCell(row, col);

            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void ChooseOneCell_ReturnEmptyBoard()
        {
            int row = 1;
            int col = 2;

            var expected = 'X';
            var actual = _gameBoard.InsertCharIntoCell(row, col);

            Assert.AreEqual(expected, actual);
        }

    }
}
