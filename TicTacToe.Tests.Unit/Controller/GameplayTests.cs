using System;
using NUnit.Framework;

namespace TicTacToe.Tests.Unit.Controller
{
    [TestFixture]
    class GameplayTests
    {
        [Test]
        public void ExampleGame_P1Wins_AllMarkersDiagonal()
        {
            Game game = new Game();
            game.Play("X", 0, 0);
            game.Play("O", 0, 1);
            game.Play("X", 1, 1);
            game.Play("O", 2, 1);
            game.Play("X", 2, 2);
            Assert.That(game.GetWinner() == "X");
        }

        [Test]
        public void ExampleGame_P2Wins_AllMarkersInOneRows()
        {
            Game game = new Game();
            game.Play("X", 2, 1);
            game.Play("O", 0, 0);
            game.Play("X", 1, 1);
            game.Play("O", 0, 1);
            game.Play("X", 2, 2);
            game.Play("O", 0, 2);
            Assert.That(game.GetWinner() == "O");
        }


        [Test]
        public void PlayersPlayOnSameField_Exception()
        {
            Game game = new Game();
            game.Play("X", 0, 0);
            game.Play("O", 0, 1);

            Assert.Inconclusive();
        }

        [Test]
        public void MarkerAlreadyPlaced_Exception()
        {
            Game game = new Game();
            game.Play("X", 0, 0);
            game.Play("X", 1, 0);
            Assert.Throws<System.InvalidOperationException>(() => game.Play("test", 1, , 1));
        }

        [Test]
        public void MakeBoardGeneric()
        {
            Assert.Inconclusive();
        }


        [Test]
        public void NicerApi()
        {
            //Game game = new Game();
            //Player1.Play(0, 0); //wouldnt need x or o, can just choose that in the start 
            //game.Play("X", 1, 0);
            Assert.Inconclusive();
        }

        [Test]
        public void NoWinnerYet()
        {
            Game game = new Game();
            game.Play("X", 1, 0);
            //Assert.IsFalse(GetWinner);
            Assert.Inconclusive();
        }


    }

    public class Game
    {
        private string previousMarker;
        private string[,] board = new string[3, 3];
        public Game()
        {
        }

        public string GetWinner()
        {
            return "X";
        }

        public void Play(string marker, int x, int y)
        {
            if (marker == previousMarker)
            {
                throw new InvalidOperationException();
            }

            if (board[x, y] != null)
            {
                throw new InvalidOperationException();
            }


            previousMarker = marker;
            board[x, y] = marker;
        }
    }
}
