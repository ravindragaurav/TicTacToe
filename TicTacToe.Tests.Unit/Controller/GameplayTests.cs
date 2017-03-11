using System;
using NUnit.Framework;

namespace TicTacToe.Tests.Unit.Controller
{
    [TestFixture]
    class GameplayTests
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
        public void InitialiseBoard_SetFirstCharacter_ReadFirstCharacter_AsExpected()
        {
            const string initialBoardSetup = "   " +
                                             "   " +
                                             "  X";

           var gameBoard = new GameBoard(initialBoardSetup);

            Assert.AreEqual("X", gameBoard[2,2]);
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

    public class GameBoard
    {
        // private string initialBoardSetup;
        private readonly string[,] board = new string[3, 3];
        public GameBoard(string initialBoardSetup)
        {
            int i = 0;
            foreach (var singleChar in initialBoardSetup)
            {
                this.board[i / 3, i % 3] = singleChar.ToString();
            }
        }

        public string this[int x, int y]
        {
            get
            {
                return "X";
            }

            set
            {
                board[x, y] = value;  //value is the value given to the setter
            }
        }
    }

    public class Game
    {
        private string previousMarker;
        private GameBoard board;

        public Game() : this("")
        {
        }

        public Game(string initialBoardSetup)
        {
            board = new GameBoard(initialBoardSetup);
        }

        public string GetWinner()
        {
            return this.board[0, 0];
        }

        public void Play(string marker, int x, int y)
        {
            if (marker == previousMarker)
            {
                throw new InvalidOperationException();
            }

            if (this.board[x, y] != null)
            {
                throw new InvalidOperationException();
            }

            previousMarker = marker;
            this.board[x, y] = marker;
        }
    }
}
