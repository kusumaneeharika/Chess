using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.ConsoleApp
{
    class Bishop : Piece
    {
        private ArrayList validMoves;
        #region Public Methods
        //public override bool IsValidMove(Board board, int dst,Direction dir)
        //{

        //}
        #endregion Public Methods
        public Bishop(PieceColor pColor, PieceType pType) : base(pColor, pType)
        {
        }

        public ArrayList  CalculatePosition(Board board)
        {
            MoveUpLeft(new Tuple<int, int>(board.GetPiecePosition(this).Item1, board.GetPiecePosition(this).Item2));
            MoveUpRight(new Tuple<int, int>(board.GetPiecePosition(this).Item1, board.GetPiecePosition(this).Item2));
            MoveDownLeft(new Tuple<int, int>(board.GetPiecePosition(this).Item1, board.GetPiecePosition(this).Item2));
            MoveDownRight(new Tuple<int, int>(board.GetPiecePosition(this).Item1, board.GetPiecePosition(this).Item2));

            return validMoves;
        }
    }

}
