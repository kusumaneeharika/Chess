using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.ConsoleApp
{
    class Rook : Piece
    {
        #region Properties
        public List<int> Moves { get; set; }
        #endregion Properties

        #region Private Variables

        #endregion Private Variables

        #region Public Methods
      
        public Rook(PieceColor pColor, PieceType pType) : base(pColor, pType)
        {
        }

        public override bool IsValidMove(Board board, int dst)
        {
            //ToDo: checking for pieces of same and diffrnt color
            int src = board.WhereIs(this);
            Tuple<int, int> srcPlace = board.GetCoordinate(Convert.ToInt32(this));
            Tuple<int, int> dstPlace = board.GetCoordinate(dst);
            
            return true;
            //Direction dir = Direction.LowerLeft;
            //if (dstPlace.Item2 < srcPlace.Item2)
            //    dir = Direction.Left;
            //else if (dstPlace.Item2 > srcPlace.Item2)
            //    dir = Direction.Right;
            //else if (dstPlace.Item1 < srcPlace.Item1)
            //    dir = Direction.Up;
            //else if (dstPlace.Item1 > srcPlace.Item1)
            //    dir = Direction.Down;
            //switch (dir)
            //{
            //    case Direction.Up:
            //        int x = board.WhereIs(this);
            //        board.SetPiece(this, dst);
            //        return true;

            //    case Direction.Down:
            //        int a = board.WhereIs(this);
            //        board.SetPiece(this, dst);
            //        return true;

            //    case Direction.Left:
            //        int y = board.WhereIs(this);
            //        board.SetPiece(this, dst);
            //        return true;

            //    case Direction.Right:
            //        int z = board.WhereIs(this);
            //        board.SetPiece(this, dst);
            //        return true;

            //    default:
            //        return false;

            //}

        }

      
        #endregion Public Methods
    }
}
