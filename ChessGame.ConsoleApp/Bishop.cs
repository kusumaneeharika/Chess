using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.ConsoleApp
{
    class Bishop : Piece
    {
        #region Public Methods
        //public override bool IsValidMove(Board board, int dst,Direction dir)
        //{

        //}
        #endregion Public Methods
        public Bishop(PieceColor pColor, PieceType pType) : base(pColor, pType)
        {
        }
    }

}
