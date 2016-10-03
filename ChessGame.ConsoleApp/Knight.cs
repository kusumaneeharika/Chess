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

        public ArrayList CalculatePositions(Board board )
        {
            UpLeft(new Tuple<int, int>(board.GetPiecePosition(this).Item1, board.GetPiecePosition(this).Item2));
            UpRight(new Tuple<int, int>(board.GetPiecePosition(this).Item1, board.GetPiecePosition(this).Item2));
            DownLeft(new Tuple<int, int>(board.GetPiecePosition(this).Item1, board.GetPiecePosition(this).Item2));
            DownRight(new Tuple<int, int>(board.GetPiecePosition(this).Item1, board.GetPiecePosition(this).Item2));
            LeftUp(new Tuple<int, int>(board.GetPiecePosition(this).Item1, board.GetPiecePosition(this).Item2));
            LeftDown(new Tuple<int, int>(board.GetPiecePosition(this).Item1, board.GetPiecePosition(this).Item2));
            RightUp(new Tuple<int, int>(board.GetPiecePosition(this).Item1, board.GetPiecePosition(this).Item2));
            RightDown(new Tuple<int, int>(board.GetPiecePosition(this).Item1, board.GetPiecePosition(this).Item2));

            return possibleMoves;
        }

        private void RightDown(Tuple<int, int> tp)
        {
            if (Rule.KnightRightDown(ref tp))
            {
                //check whether any pieces exist or not.
                ProcessMove(tp.Item1, tp.Item2);
            }
        }

        private void RightUp(Tuple<int, int> tp)
        {
            if (Rule.KnightRightUp(ref tp))
            {
                ProcessMove(tp.Item1, tp.Item2);
            }
        }

        private void LeftDown(Tuple<int, int> tp)
        {
            if (Rule.KnightLeftUp(ref tp))
            {
                ProcessMove(tp.Item1, tp.Item2);
            }
        }

        private void LeftUp(Tuple<int, int> tp)
        {
            if (Rule.KnightLeftUp(ref tp))
            {
                ProcessMove(tp.Item1, tp.Item2);
            }
        }

        private void DownRight(Tuple<int, int> tp)
        {
            if (Rule.KnightRightDown(ref tp))
            {
                ProcessMove(tp.Item1, tp.Item2);
            }
        }

        private void DownLeft(Tuple<int, int> tp)
        {
            if (Rule.KnightDownLeft(ref tp))
            {
                ProcessMove(tp.Item1, tp.Item2);
            }
        }

        private void UpRight(Tuple<int, int> tp)
        {
            if (Rule.KnightUpRight(ref tp))
            {
                ProcessMove(tp.Item1, tp.Item2);
            }
        }

        private void UpLeft(Tuple<int,int> tp)
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

