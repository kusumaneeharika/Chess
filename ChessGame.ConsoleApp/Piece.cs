using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.ConsoleApp
{
    abstract class Piece
    {

        //public bool IsWhite { get; set; }

        private PieceType PieceType { get; set; }

        private PieceColor PieceColor { get; set; }

        public bool CanCastle { get; set; }

        public Tuple<int,int> PiecePosition { get; set; }
        
        public int CurrentPosition { get; set; }
       
        public Piece(PieceColor pColor,PieceType pType)
        {
            PieceColor = pColor;
            PieceType = pType;
            CanCastle = ((pType == PieceType.King) || (pType == PieceType.Rook));
        }
        public virtual bool IsValidMove(Board board, int dst)
        {
            return true;
        }
        
    }
}
