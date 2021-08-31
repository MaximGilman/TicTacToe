using System;
using System.Drawing;
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

        public void WasClicked(Turn turn, Image image)
        {
            this.PictureBox.Image = image;
            this.PictureBox.Enabled = false;
            this.CellStatus = ToCellStatus(turn);
            
        }

        private CellStatus ToCellStatus(Turn turn)
        {
            return turn switch
            {
                Turn.None => CellStatus.Empty,
                Turn.X => CellStatus.X,
                Turn.O => CellStatus.O,
                _ => throw new ArgumentOutOfRangeException(nameof(turn), turn, null)
            };
        }
    }

}