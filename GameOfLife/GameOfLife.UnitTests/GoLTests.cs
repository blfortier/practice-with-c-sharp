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
        private Coordinates _coords;

        [SetUp]
        public void TestFixtureSetup()
        {
            _gameBoard = new GameBoard();
            // _coords = new Coordinates();
            //  _gameBoard.SetInitialState();
        }

        [Test]
        public void EnterOneRowAndColumn_ReturnCoordinatesObject()
        {
            _coords = new Coordinates(1, 5);

            var expected = false;
            var actual = _gameBoard.GetStateOfParticularCellCoordinates(_coords);
            Assert.AreEqual(expected, actual);
        }

        //[Test]
        //public void GetDictionaryOfCoords()
        //{
        //    var expected = _gameBoard.SetAllBoardCoordAndStateAsFalse();
        //    Assert.();

        //}


        //[Test]
        //public void SetUpInitialBoardWithCoords_AllCellStatesFalse()
        //{

        //}

        [Test]
        public void ChooseOneCellAndTurnStateToTrue()
        {
            _coords = new Coordinates(4, 7);

            var expected = true;
            var actual = _gameBoard.TurnStateOfCellToTrue(_coords);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IfStateOfCellCoordsIsTrue_SwitchToFalse()
        {
            _coords = new Coordinates(2, 5);
            _coords.State = true;

            var expected = false;
            Assert.AreEqual(expected, _gameBoard.SwitchAllTrueStatesToFalseStates(_coords));
        }
        
        //[Test]
        //public void ChooseOneCell_ReturnEmptyBoard()
        //{
        //    int row = 1;
        //    int col = 2;

        //    var expected = true;
        //    var actual = _gameBoard.TurnStateOfCellToTrue(row, col);

        //    Assert.AreEqual(expected, actual);
        //}
    }
}
