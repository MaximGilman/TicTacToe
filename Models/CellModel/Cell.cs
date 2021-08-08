using System.Windows.Forms;
using tictactoe.CellModel;

namespace tictactoe.Models.CellModel
{
    public class Cell
    {
        public CellStatus CellStatus { get; set; } = CellStatus.Empty;
        public PictureBox PictureBox { get; set; }
        public string Name { get; set; }
        public RowNumber Row { get; set; }
        public ColumnNumber Column { get; set; }
    }

}