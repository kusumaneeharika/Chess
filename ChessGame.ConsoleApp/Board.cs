using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.ConsoleApp
{
    class Board
    {
        private int boardSize = 64;
        private ArrayList blockList;
        //private int WhitePiece = 16;
        //private int BlackPiece = 16;

        //private int location;
        private Tuple<int,int> piecePosition;

        public Board()
        {
            piecePosition = new Tuple<int, int>(0, 0);
            blockList = new ArrayList();
        }

        Piece[,] pieces = new Piece[8,8];

        public Piece GetPiece(Tuple<int,int> location)
        {
            //Piece piece = pieces[location / 8,location % 8];
            //return piece;
            Piece piece;
            for (int i = 0; i < boardSize; i++)
            {
                piece = (Piece)blockList[i];

                if (piece != null)
                {
                    if ((GetPiecePosition().Item1 == location.Item1)
                        && (GetPiecePosition().Item2 == location.Item2))
                        return piece; 
                }
            }
            return null;
        }

        public void RemovePiece(int location)
        {

        }

        public bool MovePiece(int src, int dst)
        {
           if(dst != 0)
            {
                if (src > dst)
                {
                    src = src + dst;
                }
                else
                {
                    src = src - dst;
                }
                return true;
            }
            return false;
        }

        public Tuple<int,int> WhereIs(Piece piece)
        {
            return new Tuple<int, int>(piece.PiecePosition.Item1, piece.PiecePosition.Item2);
        }

        public void SetPiece(Piece piece,int place)
        {
            piece = pieces[place / 8, place % 8];
        }
        
        public Tuple<int,int> GetCoordinate(int place)
        {
            return new Tuple<int, int>(place / 8, place % 8);
        }

        public Tuple<int, int> GetPiecePosition(Piece piece)
        {
            return piecePosition;
        }

    }
}
