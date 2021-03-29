using Lab04_TicTacToe.Classes;
using Xunit;

namespace TicTacToeTest.cs
{
    public class PlayerTests
    {
        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(10)]
        public void PositionForNumber_returns_null_for_invalid_number(int position)
        {
            // Arrange
            // from input

            // Act
            Position result = Player.PositionForNumber(position);

            // Arrange
            Assert.Null(result);
        }

        [Theory]

        // First row
        [InlineData(1, 0, 0)]
        [InlineData(2, 0, 1)]
        [InlineData(3, 0, 2)]

        // Second row
        [InlineData(4, 1, 0)]
        [InlineData(5, 1, 1)]
        [InlineData(6, 1, 2)]

        // Third row
        [InlineData(7, 2, 0)]
        [InlineData(8, 2, 1)]
        [InlineData(9, 2, 2)]
        public void PositionForNumber_returns_expected_position_for_valid_position(
            int position, int expectedRow, int expectedColumn)
        {
            // Arrange
            // from input

            // Act
            Position result = Player.PositionForNumber(position);

            // Arrange
            // Assert.Equal(new Position(0, 0), result);
            Assert.Equal(expectedRow, result.Row);
            Assert.Equal(expectedColumn, result.Column);
        }
    }
}
