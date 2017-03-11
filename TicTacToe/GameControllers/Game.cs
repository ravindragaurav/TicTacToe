using System;


namespace TicTacToe.GameControllers
{
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