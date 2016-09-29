using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.ConsoleApp
{
    class Queen : Piece
    {
        public Queen(PieceColor pColor, PieceType pType) : base(pColor, pType)
        {
        }
        #region Properties

        #endregion Properties

        #region Private Variables

        #endregion Private Variables


        #region Public Methods

        public override bool IsValidMove(Board board, int dst)
        {
            //Todo: Need to check for other pieces when the queen is moving
            int src = board.WhereIs(this);
            Tuple<int, int> srcPlace = board.GetCoordinate(src);
            Tuple<int, int> dstPlace = board.GetCoordinate(dst);
            board.SetPiece(this, dst);
            return true;
            }
        }
        #endregion Public Methods

    }

