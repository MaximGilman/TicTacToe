using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using tictactoe.CellModel;
using tictactoe.Models.CellModel;
using tictactoe.Utils;

namespace tictactoe.Services
{
    public class CellsGenerator
    {
        private readonly TicTacToeForm _form;

        public CellsGenerator(TicTacToeForm form)
        {
            _form = form;
        }

        public Cell[,] GenerateCells()
        {
            var cells = new Cell[3, 3];
            cells[0, 0] = CreateCell(ColumnNumber.Left, RowNumber.Top);
            cells[0, 1] = CreateCell(ColumnNumber.Center, RowNumber.Top);
            cells[0, 2] = CreateCell(ColumnNumber.Right, RowNumber.Top);

            cells[1, 0] = CreateCell(ColumnNumber.Left, RowNumber.Middle);
            cells[1, 1] = CreateCell(ColumnNumber.Center, RowNumber.Middle);
            cells[1, 2] = CreateCell(ColumnNumber.Right, RowNumber.Middle);


            cells[2, 0] = CreateCell(ColumnNumber.Left, RowNumber.Bottom);
            cells[2, 1] = CreateCell(ColumnNumber.Center, RowNumber.Bottom);
            cells[2, 2] = CreateCell(ColumnNumber.Right, RowNumber.Bottom);


            
            return cells;
        }


        public Cell CreateCell(ColumnNumber column, RowNumber row)
        {
            string camelCasedControlName = GetName(column, row);
           return new Cell()
            {
                Column = column,
                Row = row,
                Name = camelCasedControlName,
                PictureBox = GetControlByName<PictureBox>(camelCasedControlName)
            };
        }

        private string GetName(ColumnNumber column, RowNumber row)
        {
            string pictureBoxControlName =
                $"{row.ToString()}_{column.ToString()}_{FormConstants.PictureBoxPrefix}";

            return pictureBoxControlName.ToCamelCase("_");
        }

        private T GetControlByName<T>(string controlName) where T: class
        => _form.Controls[controlName] as T;
        

      
    }
}