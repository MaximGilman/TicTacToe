using System;
using tictactoe.CellModel;
using tictactoe.Models.CellModel;

namespace tictactoe.Services
{
    public class CellPlaceSelector
    {
        private const int DefaultLength = 35;
        public CellPlaceSelector()
        {
        }

        public (int x, int y) GetCellLocation(Cell cell)
        {
            var x = cell.Column switch
            {
                ColumnNumber.Left => DefaultLength,
                ColumnNumber.Center => DefaultLength * 2,
                ColumnNumber.Right => DefaultLength * 3,
                _ => throw new ArgumentOutOfRangeException()
            };
            
            var y = cell.Row switch
            {
                RowNumber.Top => DefaultLength,
                RowNumber.Middle => DefaultLength * 2,
                RowNumber.Bottom => DefaultLength * 3,
                _ => throw new ArgumentOutOfRangeException()
            };

            return (x, y);
        }
    }
}