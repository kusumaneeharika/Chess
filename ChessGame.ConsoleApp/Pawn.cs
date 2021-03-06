﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.ConsoleApp
{
    class Pawn : Piece
    {
        private ArrayList validMoves;

        #region Properties
        public bool IsWhiteOrBlack { get; set; }

        #endregion Properties

        #region Constructor
        public Pawn(PieceColor pColor, PieceType pType) : base(pColor, pType)
        {
        }
        #endregion Constructor

        #region Private Variables
        //private int stepCount;
        #endregion Private Variables

        #region Public Methods
        public override bool IsValidMove(Board board, int dst)
        {
            //Piece[][] piece = new Piece[8][];
            //int initial = board.WhereIs();
            return false;
        }

        public ArrayList CalculatePositions(Board board)
        {
            MoveUp(new Tuple<int, int>(board.GetPiecePosition(this).Item1, board.GetPiecePosition(this).Item2));
            MoveDown(new Tuple<int, int>(board.GetPiecePosition(this).Item1, board.GetPiecePosition(this).Item2));

            return validMoves;
        }
        #endregion Public Methods
    }
}
