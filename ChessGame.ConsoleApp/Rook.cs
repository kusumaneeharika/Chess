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

        #endregion Properties

        #region Private Variables

        #endregion Private Variables

        #region Public Methods
        //need to complete this overide method
        public override bool IsValidMove(Board board, int dst)
        {
            int i, j;
            // int stepCount = board.CalculateSteps(this, dst);
            int src = board.WhereIs(this);
            Tuple<int,int> srcPlace = board.GetCoordinate(src);
            Tuple<int, int> dstPlace = board.GetCoordinate(dst);
            if (dstPlace.Item2 < srcPlace.Item2)
                return Direction.Left;
            switch (dir)
            {
                case Direction.Up:
                    int x = board.WhereIs(this);
                    //int toUp = x + stepCount;
                    board.SetPiece(this, dst);
                    return true;

                case Direction.Down:
                    int a = board.WhereIs(this);
                   // int toDown = a - stepCount;
                    board.SetPiece(this, dst);
                    return true;

                case Direction.Left:
                    int y = board.WhereIs(this);
                    //int leftPlace = y - stepCount;
                    board.SetPiece(this, dst);
                    return true;

                case Direction.Right:
                    int z = board.WhereIs(this);
                    //int place = z + stepCount;
                    board.SetPiece(this, dst);
                    return true;

                default:
                    return false;

            }


        }

        public bool CalculateDirection(Board board, int dst)
        {
            int currentPlace = board.WhereIs(this);
           
            return false;
        }
      
        #endregion Public Methods
    }
}
