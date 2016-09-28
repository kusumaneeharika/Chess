﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.ConsoleApp
{
    class Rook : Piece
    {
        #region Properties
        public List<int> Moves { get; set; }
        #endregion Properties

        #region Private Variables

        #endregion Private Variables

        #region Public Methods
        public Rook()
        {
            Moves = new List<int>();
            Moves.Add((int)Direction.Up);
            Moves.Add((int)Direction.Down);
            Moves.Add((int)Direction.Left);
            Moves.Add((int)Direction.Right);
        }


        public override bool IsValidMove(Board board, int dst)
        {

            // int stepCount = board.CalculateSteps(this, dst);
            int src = board.WhereIs(this);
            Tuple<int, int> srcPlace = board.GetCoordinate(src);
            Tuple<int, int> dstPlace = board.GetCoordinate(dst);
            Direction dir = Direction.LowerLeft;
            if (dstPlace.Item2 < srcPlace.Item2)
                dir = Direction.Left;
            else if (dstPlace.Item2 > srcPlace.Item2)
                dir = Direction.Right;
            else if (dstPlace.Item1 < srcPlace.Item1)
                dir = Direction.Up;
            else if (dstPlace.Item1 > srcPlace.Item1)
                dir = Direction.Down;
            switch (dir)
            {
                case Direction.Up:
                    int x = board.WhereIs(this);
                    //int toUp = x + stepCount;
                    board.SetPiece(this, dst);
                    return true;

                case Direction.Down:
                    int a = board.WhereIs(this);
                    // int toDown = a - stepCount;
                    board.SetPiece(this, dst);
                    return true;

                case Direction.Left:
                    int y = board.WhereIs(this);
                    //int leftPlace = y - stepCount;
                    board.SetPiece(this, dst);
                    return true;

                case Direction.Right:
                    int z = board.WhereIs(this);
                    //int place = z + stepCount;
                    board.SetPiece(this, dst);
                    return true;

                default:
                    return false;

            }


        }

        #endregion Public Methods
    }
}
