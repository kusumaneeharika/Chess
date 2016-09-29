using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.ConsoleApp
{
    class Pawn : Piece
    {
        public Pawn(PieceColor pColor, PieceType pType) : base(pColor, pType)
        {
        }
        #region Properties
        public bool IsWhiteOrBlack { get; set; }

        #endregion Properties

        #region Constructor

        #endregion Constructor

        #region Private Variables
        //private int stepCount;
        #endregion Private Variables

        #region Public Methods
        //public override bool IsValidMove(Board board, int dst)
        //{
        //    Piece[][] piece = new Piece[8][];
        //    int initial = board.WhereIs();

        //}

        #endregion Public Methods
    }
}
