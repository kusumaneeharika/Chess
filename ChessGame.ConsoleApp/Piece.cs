using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.ConsoleApp
{
    abstract class Piece
    {
        #region Properties
        public bool IsWhite { get; set; }
        
        public int CurrentPosition { get; set; }
        #endregion Properties

        #region Public Methods
        public virtual bool IsValidMove(Board board, int dst)
        {
            return true;
        }
        #endregion Public Methods
    }
}
