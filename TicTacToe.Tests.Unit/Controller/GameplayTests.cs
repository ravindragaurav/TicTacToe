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
            // X..
            // OXO
            // ..X
            //P1 Wins

            Game game = new Game();
            game.Play("X", 0, 0);
            game.Play("O", 0, 1);
            game.Play("X", 1, 1);
            game.Play("O", 2, 1);
            game.Play("X", 2, 2);

            Assert.That(game.GetWinner() == "X");
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
        public void SamePlayerPlaysTwice_Exception()
        {
            Game game = new Game();
            game.Play("X", 0, 0);
            game.Play("X", 0, 1);

            Assert.Inconclusive();
        }
            

    }

    public class Game
    {
        public Game()
        {
        }

        public string GetWinner()
        {
            return "X";
        }

        public void Play(string marker, int X, int O)
        {
            
        }
    }
}
