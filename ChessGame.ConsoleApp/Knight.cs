using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.ConsoleApp
{
    class Knight : Piece
    {
        #region Public Methods
        public ArrayList possibleMoves = new ArrayList();

        public Knight(PieceColor pColor, PieceType pType) : base(pColor, pType)
        {
        }

        public override bool IsValidMove(Board board, int dst)
        {
            return base.IsValidMove(board, dst);
        }

        public ArrayList CalculatePositions(Board board, int dst)
        {
            UpLeft(new Tuple<int,int>(board.GetPiecePosition().Item1, board.GetPiecePosition().Item2), dst);
            UpRight(new Tuple<int, int>(board.GetPiecePosition().Item1, board.GetPiecePosition().Item2), dst);
            DownLeft(new Tuple<int, int>(board.GetPiecePosition().Item1, board.GetPiecePosition().Item2), dst);
            DownRight(new Tuple<int, int>(board.GetPiecePosition().Item1, board.GetPiecePosition().Item2), dst);
            LeftUp(new Tuple<int, int>(board.GetPiecePosition().Item1, board.GetPiecePosition().Item2), dst);
            LeftDown(new Tuple<int, int>(board.GetPiecePosition().Item1, board.GetPiecePosition().Item2), dst);
            RightUp(new Tuple<int, int>(board.GetPiecePosition().Item1, board.GetPiecePosition().Item2), dst);
            RightDown(new Tuple<int, int>(board.GetPiecePosition().Item1, board.GetPiecePosition().Item2), dst);

            return possibleMoves;
        }

        public void UpLeft(Tuple<int,int> tp,int dst)
        {
            
        }

        #endregion Public Methods
    }
}
