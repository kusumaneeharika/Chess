using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.ConsoleApp
{
    class Queen : Piece
    {
        #region Properties
        public List<int> Moves { get; set; }
        #endregion Properties

        #region Private Variables

        #endregion Private Variables


        #region Public Methods
        public Queen()
        {
            Moves = new List<int>();
            Moves.Add((int)Direction.Up);
            Moves.Add((int)Direction.Down);
            Moves.Add((int)Direction.Left);
            Moves.Add((int)Direction.Right);
            Moves.Add((int)Direction.UpperLeft);
            Moves.Add((int)Direction.UpperRight);
            Moves.Add((int)Direction.LowerLeft);
            Moves.Add((int)Direction.LowerRight);
        }

        public override bool IsValidMove(Board board, int dst)
        {
            //Todo: Need to check for other pieces when the queen is moving
            int src = board.WhereIs(this);
            Tuple<int, int> srcPlace = board.GetCoordinate(src);
            Tuple<int, int> dstPlace = board.GetCoordinate(dst);
            Direction dir;
            if (dstPlace.Item2 < srcPlace.Item2)
                dir = Direction.Left;
            else if (dstPlace.Item2 > srcPlace.Item2)
                dir = Direction.Right;
            else if (dstPlace.Item1 < srcPlace.Item1)
                dir = Direction.Up;
            else if (dstPlace.Item1 > srcPlace.Item1)
                dir = Direction.Down;
            else if (dstPlace.Item1 < srcPlace.Item1 && dstPlace.Item2 < srcPlace.Item2)
                dir = Direction.UpperLeft;
            else if (dstPlace.Item1 < srcPlace.Item1 && dstPlace.Item2 > srcPlace.Item2)
                dir = Direction.UpperRight;
            else if (dstPlace.Item1 > srcPlace.Item1 && dstPlace.Item2 < srcPlace.Item2)
                dir = Direction.LowerLeft;
            else
                dir = Direction.LowerRight;
            switch (dir)
            {
                case Direction.Up:
                    board.SetPiece(this, dst);
                    return true;
                case Direction.Down:
                    board.SetPiece(this, dst);
                    return true;
                case Direction.Left:
                    board.SetPiece(this, dst);
                    return true;
                case Direction.Right:
                    board.SetPiece(this, dst);
                    return true;
                case Direction.LowerLeft:
                    board.SetPiece(this, dst);
                    return true;
                case Direction.LowerRight:
                    board.SetPiece(this, dst);
                    return true;
                case Direction.UpperLeft:
                    board.SetPiece(this, dst);
                    return true;
                case Direction.UpperRight:
                    board.SetPiece(this, dst);
                    return true;
                default:
                    return false;
            }
        }
        #endregion Public Methods

    }
}
