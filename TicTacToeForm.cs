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
        private Cell[,] _cells;
        private TurnHandler _turnHandler;
        private PictureSelector _pictureSelector;
        private WinnerChecker _winnerChecker;
        private CellsGenerator _cellsGenerator;
        public TicTacToeForm()
        {
            InitializeComponent();
            _cellsGenerator = new CellsGenerator(this);
            _pictureSelector = new PictureSelector(AppDomain.CurrentDomain.BaseDirectory);
            Init();

            _winnerChecker.WinnerWasFound += WinnerWasFound;
            _winnerChecker.NoMoreTurns += NoMoreTurns; ;

        }

     

        private void Cell_Click(object sender, EventArgs e)
        {
            var typicalSender = sender as Control;
            Cell cell = _cells.GetCellByName(typicalSender?.Name);
            var turn = _turnHandler.NexTurn();
            var image = _pictureSelector.SelectImageByTurn(turn);
            cell.WasClicked(turn, image);
            _winnerChecker.CheckWinner(_cells, turn);
        }
        private void NoMoreTurns()
        {
            MessageBox.Show($@"Ходы закончились", "Игра окончена", MessageBoxButtons.OK);
            Restart();
        }
        private void WinnerWasFound(Turn winnerTurn)
        {
            MessageBox.Show($@"Победитель найден! Это {winnerTurn}", "Игра окончена", MessageBoxButtons.OK);
            Restart();
        }

        private void Restart()
        {
            Init();
            Application.Restart();
        }

        private void Init()
        {
            _cells = _cellsGenerator.GenerateCells();
            _turnHandler = new TurnHandler();
            _winnerChecker = new WinnerChecker();
        }
    }
}
