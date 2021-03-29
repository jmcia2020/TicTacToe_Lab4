namespace Lab04_TicTacToe.Classes
{
    public class Position
    {
        public int Row { get; set; }
        public int Column { get; set; }

        /// <summary>
        /// Position on the gameboard being initialized 
        /// </summary>
        /// <param name="row">row number</param>
        /// <param name="column">column number</param>
        public Position(int row, int column)
        {
            Row = row;
            Column = column;
        }

        public override bool Equals(object obj)
        {
            if (obj is Position p)
                return p.Row == Row && p.Column == Column;

            return false;
        }

        public override int GetHashCode()
        {
            return Row.GetHashCode() ^ Column.GetHashCode();
        }
    }
}
