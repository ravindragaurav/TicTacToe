using System;
using NUnit.Framework;
using TicTacToe.GameControllers;

namespace TicTacToe.Tests.Unit.Controller
{
    [TestFixture]
    class TicTacToeSpecifications
    {
        Game game = new Game();

        [Test]
        public void ExampleGame_P1Wins_AllMarkersInOneRow()
        {
           
            game.Play("X", 0, 0);
            game.Play("O", 0, 1);
            game.Play("X", 1, 0);
            game.Play("O", 2, 1);
            game.Play("X", 2, 0);
            Assert.That(game.GetWinner() == "X");
        }

        [Test]
        public void ExampleGame_P2Wins_AllMarkersInOneRow()
        {
            game.Play("X", 2, 1);
            game.Play("O", 0, 0);
            game.Play("X", 1, 1);
            game.Play("O", 0, 1);
            game.Play("X", 2, 2);
            game.Play("O", 0, 2);
            Assert.That(game.GetWinner() == "O");
        }

        [Test]
        public void InitialiseBoard_XInARow_GetWinnerIsX()
        {
            const string initialBoardSetup = "XXX" +
                                             "   " +
                                             "   ";

            Game game = new Game(initialBoardSetup);

            Assert.IsTrue(game.GetWinner() == "X");
        }

     

        [Test]
        public void SamePlayerPlaysTwice_Exception()
        {
            game.Play("X", 0, 0);
            Assert.Throws<InvalidOperationException>(() => game.Play("X", 1, 0));
        }

        [Test]
        public void MarkerAlreadyPlaced_Exception()
        {
            game.Play("X", 0, 0);
            Assert.Throws<InvalidOperationException>(() => game.Play("O", 0, 0));
        }


        [Test]
        public void MakeBoardGeneric()
        {
            Assert.Inconclusive();
        }


        [Test]
        public void NicerApi()
        {
            //Player1.Play(0, 0); //wouldnt need x or o, can just choose that in the start 
            //game.Play("X", 1, 0);
            //game.Play("P1, 1, 0);
            Assert.Inconclusive();
        }

        [Test]
        public void NoWinnerYet()
        {
            game.Play("X", 1, 0);
            //Assert.IsFalse(GetWinner);
            Assert.Inconclusive();
        }

    }

   
}
