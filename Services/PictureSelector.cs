using System;
using System.Diagnostics;
using System.Drawing;
using static tictactoe.PathConstants;

namespace tictactoe.Services
{
    public class PictureSelector
    {
        private readonly Image _o;
        private readonly Image _x;

        public PictureSelector()
        {
            
            _o = Properties.Resources.o; 
            _x = Properties.Resources.x;
        }

        public Image SelectImageByTurn(Turn turn)
        {
            return turn switch
            {
                Turn.X => _x,
                Turn.O => _o,
                _ => throw new ArgumentOutOfRangeException(nameof(turn), turn, null)
            };
        }
    }
}