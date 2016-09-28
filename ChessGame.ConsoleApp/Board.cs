using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.ConsoleApp
{
    class Board
    {
        //private int boardSize = 64;
        //private int WhitePiece = 16;
        //private int BlackPiece = 16;

        //private int location;
        Piece[,] pieces = new Piece[8,8];

        public Piece GetPiece(int location)
        {
            Piece piece = pieces[location / 8,location % 8];
            return piece;
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

        public int WhereIs(Piece piece)
        {
            return piece.CurrentPosition;
        }

        public void SetPiece(Piece piece,int place)
        {
            piece = pieces[place / 8, place % 8];
        }

        public int CalculateSteps(Piece piece, int dst)
        {
            int currentPosition = piece.CurrentPosition;
            int stepsToTake = dst - currentPosition;
            return stepsToTake;
        }

        public Tuple<int,int> GetCoordinate(int place)
        {
            return new Tuple<int, int>(place / 8, place % 8);
        }

    }
}
