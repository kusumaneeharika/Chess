using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.ConsoleApp
{
   public enum Direction
    {
        Up,
        Down,
        Left,
        Right,
        UpperLeft,
        UpperRight,
        LowerLeft,
        LowerRight,

    }

    public enum PieceColor
    {
        White,
        Black
    }

    public enum GameExceptions
    {
        InvalidMove ,
    }
}
