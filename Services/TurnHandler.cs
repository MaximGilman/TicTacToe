using System;

namespace tictactoe.Services
{
    public class TurnHandler
    {
        private Turn _turn = Turn.None;

        public TurnHandler()
        {
        }

        public Turn NexTurn()
        {
            switch (_turn)
            {
                case Turn.X:
                    _turn=  Turn.O;
                    break;
                case Turn.O:
                case Turn.None:
                    _turn = Turn.X;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return _turn;
        }
        
    }
}