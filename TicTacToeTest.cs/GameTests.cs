using Lab04_TicTacToe.Classes;
using Xunit;

namespace TicTacToeTest.cs
{
    public class GameTests
    {
        [Fact]
        public void CheckForWinner_detects_first_row()
        {
            // Arrange
            Board board = new Board();

            board.GameBoard[0, 0] = "X";
            board.GameBoard[0, 1] = "X";
            board.GameBoard[0, 2] = "X";

            // Act
            bool result = Game.CheckForWinner(board);

            // Assert
            Assert.True(result);
        }
    }
}
