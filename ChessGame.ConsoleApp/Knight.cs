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
            UpLeft(new Tuple<int, int>(board.GetPiecePosition().Item1, board.GetPiecePosition().Item2), dst);
            UpRight(new Tuple<int, int>(board.GetPiecePosition().Item1, board.GetPiecePosition().Item2), dst);
            DownLeft(new Tuple<int, int>(board.GetPiecePosition().Item1, board.GetPiecePosition().Item2), dst);
            DownRight(new Tuple<int, int>(board.GetPiecePosition().Item1, board.GetPiecePosition().Item2), dst);
            LeftUp(new Tuple<int, int>(board.GetPiecePosition().Item1, board.GetPiecePosition().Item2), dst);
            LeftDown(new Tuple<int, int>(board.GetPiecePosition().Item1, board.GetPiecePosition().Item2), dst);
            RightUp(new Tuple<int, int>(board.GetPiecePosition().Item1, board.GetPiecePosition().Item2), dst);
            RightDown(new Tuple<int, int>(board.GetPiecePosition().Item1, board.GetPiecePosition().Item2), dst);

            return possibleMoves;
        }

        private void RightDown(Tuple<int, int> tp, int dst)
        {
            if (Rule.KnightRightDown(ref tp))
            {
                //check whether any pieces exist or not.
                ProcessMove(tp.Item1, tp.Item2);
            }
        }

        private void RightUp(Tuple<int, int> tp, int dst)
        {
            if (Rule.KnightRightUp(ref tp))
            {
                ProcessMove(tp.Item1, tp.Item2);
            }
        }

        private void LeftDown(Tuple<int, int> tp, int dst)
        {
            if (Rule.KnightLeftUp(ref tp))
            {
                ProcessMove(tp.Item1, tp.Item2);
            }
        }

        private void LeftUp(Tuple<int, int> tp, int dst)
        {
            if (Rule.KnightLeftUp(ref tp))
            {
                ProcessMove(tp.Item1, tp.Item2);
            }
        }

        private void DownRight(Tuple<int, int> tp, int dst)
        {
            if (Rule.KnightDownRight(ref tp))
            {
                ProcessMove(tp.Item1, tp.Item2);
            }
        }

        private void DownLeft(Tuple<int, int> tp, int dst)
        {
            if (Rule.KnightDownLeft(ref tp))
            {
                ProcessMove(tp.Item1, tp.Item2);
            }
        }

        private void UpRight(Tuple<int, int> tp, int dst)
        {
            if (Rule.KnightUpRight(ref tp))
            {
                ProcessMove(tp.Item1, tp.Item2);
            }
        }

        public void UpLeft(Tuple<int,int> tp,int dst)
        {
            if(Rule.KnightUpLeft(ref tp))
            {
                ProcessMove(tp.Item1, tp.Item2);
            }
        }

        private bool ProcessMove(int item1, int item2)
        {
            Board board = new Board();
            Piece p = board.GetPiece(new Tuple<int, int>(item1, item2));
            if(p != null)
            {
               
            }
            return false;
        }
        #endregion Public Methods
    }
}

