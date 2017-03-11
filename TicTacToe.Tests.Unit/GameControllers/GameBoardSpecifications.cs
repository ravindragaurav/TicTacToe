using NUnit.Framework;
using TicTacToe.GameControllers;

namespace TicTacToe.Tests.Unit.Controller
{
    [TestFixture]
    class GameBoardSpecifications
    {
        [Test]
        public void InitBoard_()
        {

            var gameBoard = new GameBoard("X");

            Assert.AreEqual("X", gameBoard[0, 0]);
        }

        [Test]
        public void InitBoard_X()
        {

            var gameBoard = new GameBoard(" X");

            Assert.AreEqual("X", gameBoard[1, 0]);
        }

        [Test]
        public void InitBoard_SetLastCharacter_ReadLastCharacter_AsExpected()
        {
            const string initialBoardSetup = "   " +
                                             "   " +
                                             "  X";

            var gameBoard = new GameBoard(initialBoardSetup);

            Assert.AreEqual("X", gameBoard[2, 2]);
        }
    }
}
