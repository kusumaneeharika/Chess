using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.ConsoleApp
{
    class Knight : Piece
    {
        #region Public Methods
        public override bool IsValidMove(Board board, int dst)
        {
            return base.IsValidMove(board, dst);
        }
        #endregion Public Methods
    }
}
