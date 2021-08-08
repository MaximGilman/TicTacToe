using System;
using System.Diagnostics;
using System.Drawing;
using static tictactoe.PathConstants;

namespace tictactoe.Services
{
    public class PictureSelector
    {
        private readonly Image O;
        private readonly Image X;

        public PictureSelector(string basePath)
        {
            O = Image.FromFile($"{basePath}{RelativePath}{OFileNameConstant}{FileExtension}"); 
            X = Image.FromFile($"{basePath}{RelativePath}{XFileNameConstant}{FileExtension}");
        }

        public Image SelectImageByTurn(Turn turn)
        {
            return turn switch
            {
                Turn.X => X,
                Turn.O => O,
                _ => throw new ArgumentOutOfRangeException(nameof(turn), turn, null)
            };
        }
    }
}