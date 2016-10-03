using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.ConsoleApp
{
    class King : Piece
    {
        private ArrayList validMoves;

        public King(PieceColor pColor, PieceType pType) : base(pColor, pType)
        {
        }
        #region Public Methods
        public override bool IsValidMove(Board board, int dst)
        {
            return base.IsValidMove(board, dst);
        }

        public ArrayList CalculatePositions(Board board)
        {
            MoveUp(new Tuple<int, int>(board.GetPiecePosition(this).Item1, board.GetPiecePosition(this).Item2));
            MoveDown(new Tuple<int, int>(board.GetPiecePosition(this).Item1,board.GetPiecePosition(this).Item2));
            MoveLeft(new Tuple<int, int>(board.GetPiecePosition(this).Item1, board.GetPiecePosition(this).Item2));
            MoveRight(new Tuple<int, int>(board.GetPiecePosition(this).Item1, board.GetPiecePosition(this).Item2));
            MoveUpLeft(new Tuple<int, int>(board.GetPiecePosition(this).Item1, board.GetPiecePosition(this).Item2));
            MoveUpRight(new Tuple<int, int>(board.GetPiecePosition(this).Item1, board.GetPiecePosition(this).Item2));
            MoveDownLeft(new Tuple<int, int>(board.GetPiecePosition(this).Item1, board.GetPiecePosition(this).Item2));
            MoveDownRight(new Tuple<int, int>(board.GetPiecePosition(this).Item1, board.GetPiecePosition(this).Item2));

            return validMoves;
        }

        private void MoveDownRight(Tuple<int, int> tuple)
        {
            //increment both x and y
            throw new NotImplementedException();
        }

        private void MoveDownLeft(Tuple<int, int> tuple)
        {
            //decrement x and increment y
            throw new NotImplementedException();
        }

        private void MoveUpRight(Tuple<int, int> tuple)
        {
            //increment x and decrement y
            throw new NotImplementedException();
        }

        private void MoveUpLeft(Tuple<int, int> tuple)
        {
            //decrement x and decrement y
            throw new NotImplementedException();
        }

        private void MoveRight(Tuple<int, int> tuple)
        {
            //increment x
            throw new NotImplementedException();
        }

        private void MoveLeft(Tuple<int, int> tuple)
        {
            //decrement x
            throw new NotImplementedException();
        }

        private void MoveDown(Tuple<int, int> tuple)
        {
            //deccrement y
            throw new NotImplementedException();
        }

        private void MoveUp(Tuple<int, int> tuple)
        {
            //increment y
            throw new NotImplementedException();
        }

        #endregion Public Methods
    }
}
