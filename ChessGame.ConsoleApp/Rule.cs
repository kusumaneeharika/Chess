using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.ConsoleApp
{
    class Rule
    {
        public Rule()
        {

        }

        public bool Validate(int x, int y)
        {
            bool isValid = ((x >= 0) && (x <= 7) && (y >= 0) && (y <= 7));
            return isValid;
        }

        public bool DecrementY(ref Tuple<int,int> pPosition)
        {
            if (Validate(pPosition.Item1, pPosition.Item2 - 1))
            {
                // giving error when placed pPosition.Item2 = pPosition.Item2 - 1: its not a valid format
                pPosition = new Tuple<int, int>(pPosition.Item1, pPosition.Item2 - 1);
                return true;
            }
            else
                return false;
        }

        private bool DecrementX(ref Tuple<int, int> pPosition)
        {
            if (Validate(pPosition.Item1 - 1, pPosition.Item2 ))
            {
                pPosition = new Tuple<int, int>(pPosition.Item1 - 1, pPosition.Item2);
                return true;
            }
            else
                return false;
        }

        public bool KnightUpLeft(ref Tuple<int, int> pPosition)
        {
            if (DecrementY( ref pPosition) && DecrementX( ref pPosition))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

      

        public bool KnightUpRight(ref Piece pPosition)
        {
            if ( /*check conditions for upper right position of knight*/ )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // implement for other 6 positions too.
    }
}
