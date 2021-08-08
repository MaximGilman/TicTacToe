using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tictactoe.CellModel;
using tictactoe.Models.CellModel;
using tictactoe.Services;
using tictactoe.Utils;

namespace tictactoe
{
    public partial class TicTacToeForm : Form
    {
        private CellPlaceSelector _cellPlaceSelector;
        private Cell[,] _cells;
        private TurnHandler _turnHandler;
        private PictureSelector _pictureSelector;
        public TicTacToeForm()
        {
            InitializeComponent();

            _cellPlaceSelector = new CellPlaceSelector(); // на удаление
            
            _cells = new CellsGenerator(this).GenerateCells();
            _turnHandler = new TurnHandler();
            _pictureSelector = new PictureSelector(AppDomain.CurrentDomain.BaseDirectory);
        }

        private void Cell_Click(object sender, EventArgs e)
        {
            var typicalSender = sender as Control;
            Cell cell = _cells.GetCellByName(typicalSender?.Name);
            var turn = _turnHandler.NexTurn();
            cell.PictureBox.Image = _pictureSelector.SelectImageByTurn(turn);
            cell.PictureBox.Enabled = false;
        }

    }
}
