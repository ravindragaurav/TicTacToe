
namespace TicTacToe.GameControllers
{
    public class GameBoard
    {
        // private string initialBoardSetup;
        private readonly string[,] board = new string[3, 3];
        public GameBoard(string initialBoardSetup)
        {
            int i = 0;
            foreach (var singleChar in initialBoardSetup)
            {
                this.board[i % 3, i / 3] = singleChar.ToString();
                i++;
            }
        }

        public string this[int x, int y]
        {
            get
            {
                return board[x, y];
            }

            set
            {
                board[x, y] = value;  //value is the value given to the setter
            }
        }
    }
}