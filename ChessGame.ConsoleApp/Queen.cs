using System;
using System.Collections;
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
         private ArrayList validMoves;
        #endregion Private Variables


        #region Public Methods

        public override bool IsValidMove(Board board, int dst)
        {
            //Todo: Need to check for other pieces when the queen is moving
            //int src = board.WhereIs(this);
            Tuple<int, int> srcPlace = board.WhereIs(this);
            //Tuple<int, int> dstPlace = board.WhereIs(dst);
            board.SetPiece(this, dst);
            return true;
        }




    public ArrayList CalculatePositions(Board board)
    {
        MoveUp(new Tuple<int, int>(board.GetPiecePosition().Item1, board.GetPiecePosition().Item2));
        MoveDown(new Tuple<int, int>(board.GetPiecePosition().Item1, board.GetPiecePosition().Item2));
        MoveLeft(new Tuple<int, int>(board.GetPiecePosition().Item1, board.GetPiecePosition().Item2));
        MoveRight(new Tuple<int, int>(board.GetPiecePosition().Item1, board.GetPiecePosition().Item2));
        MoveUpLeft(new Tuple<int, int>(board.GetPiecePosition().Item1, board.GetPiecePosition().Item2));
        MoveUpRight(new Tuple<int, int>(board.GetPiecePosition().Item1, board.GetPiecePosition().Item2));
        MoveDownLeft(new Tuple<int, int>(board.GetPiecePosition().Item1, board.GetPiecePosition().Item2));
        MoveDownRight(new Tuple<int, int>(board.GetPiecePosition().Item1, board.GetPiecePosition().Item2));

        return validMoves;
    }

   
        #endregion Public Methods
    }
}

