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
        public void fStateOfCellIsFalse_SwitchToTrue()
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
    }
}
