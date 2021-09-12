using System;
using System.Linq;
using System.Windows.Forms;
using tictactoe.CellModel;
using tictactoe.Models.CellModel;

namespace tictactoe.Services
{
    public class WinnerChecker
    {
        public WinnerChecker()
        {
        }

        public delegate void WinnerDelegate(Turn winnerTurn);
        public delegate void FinishDelegate();

        public event WinnerDelegate WinnerWasFound;
        public event FinishDelegate NoMoreTurns;

        public void CheckWinner(Cell[,] cells, Turn turn)
        {
            if (IsColumnWin(cells, turn) || IsRowWin(cells, turn) | IsDiagonalWin(cells, turn))
            {
                WinnerWasFound?.Invoke(turn);
            }

            if (cells.OfType<Cell>().All(x => x.CellStatus != CellStatus.Empty))
            {
                NoMoreTurns?.Invoke();
            }
        }



        private bool IsRowWin(Cell[,] cells, Turn turn)
        {
            // Один  не пустой и все равны. Условие что все пустые этим исключается

            bool isTopRowEqual = cells[0, 0].CellStatus != CellStatus.Empty &&
                                 cells[0, 0].CellStatus == (cells[0, 1].CellStatus) && (cells[0, 1].CellStatus == cells[0, 2].CellStatus);

            bool isMidRowEqual = cells[1, 0].CellStatus != CellStatus.Empty &&
                                 cells[1, 0].CellStatus == (cells[1, 1].CellStatus) && (cells[1, 1].CellStatus == cells[1, 2].CellStatus);

            bool isLowRowEqual = cells[2, 0].CellStatus != CellStatus.Empty &&
                                 cells[2, 0].CellStatus == (cells[2, 1].CellStatus) && (cells[2, 1].CellStatus == cells[2, 2].CellStatus);


            return isLowRowEqual || isMidRowEqual || isTopRowEqual;
        }

        private bool IsColumnWin(Cell[,] cells, Turn turn)
        {
            // Один  не пустой и все равны. Условие что все пустые этим исключается

            bool isLeftColumnEqual = cells[0, 0].CellStatus != CellStatus.Empty &&
                                      cells[0, 0].CellStatus == (cells[1, 0].CellStatus) && (cells[1, 0].CellStatus == cells[2, 0].CellStatus);

            bool isMidColumnEqual = cells[0, 1].CellStatus != CellStatus.Empty &&
                                      cells[0, 1].CellStatus == (cells[1, 1].CellStatus) && (cells[1, 1].CellStatus == cells[2, 1].CellStatus);

            bool isRightColumnEqual = cells[0, 2].CellStatus != CellStatus.Empty &&
                                      cells[0, 2].CellStatus == (cells[1, 2].CellStatus) && (cells[1, 2].CellStatus == cells[2, 2].CellStatus);

            return isLeftColumnEqual || isMidColumnEqual || isRightColumnEqual;
        }

        private bool IsDiagonalWin(Cell[,] cells, Turn turn)
        {
            // Один  не пустой и все равны. Условие что все пустые этим исключается

            bool isLeftToRightDiagonalEqual = cells[0, 0].CellStatus != CellStatus.Empty &&
                                              cells[0, 0].CellStatus == (cells[1, 1].CellStatus) &&
                                              (cells[1, 1].CellStatus == cells[2, 2].CellStatus);

            bool isRightToLeftDiagonalEqual = cells[0, 2].CellStatus != CellStatus.Empty &&
                                              cells[0, 2].CellStatus == (cells[1, 1].CellStatus) &&
                                              (cells[1, 1].CellStatus == cells[2, 0].CellStatus);

            return isLeftToRightDiagonalEqual || isRightToLeftDiagonalEqual;
        }
    }
}