using System.Collections.Generic;
using tictactoe.CellModel;
using tictactoe.Models.CellModel;

namespace tictactoe.Utils
{
    public static class ArrayExtensions
    {
        public static Cell GetCellByName(this Cell[,] cells, string name)
        {
            foreach (var cell in cells)
            {
                if (cell.Name == name) return cell;
            }

            throw new KeyNotFoundException();
        }
    }
}