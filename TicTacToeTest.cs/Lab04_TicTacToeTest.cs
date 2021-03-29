using System;
using Xunit;

namespace TicTacToeTest.cs
{
    public class UnitTest1
    {
        [Fact]
            public void Test_if_winner_works()
            {
                // Arrange
                Board board = new Board();

                // Act
                board.GameBoard[0, 0] = "X";
                board.GameBoard[0, 1] = "X";
                board.GameBoard[0, 2] = "X";

                // Assert
                Assert.True(Game.CheckForWinner(board));
            }
        }
    }
}
    }
}
