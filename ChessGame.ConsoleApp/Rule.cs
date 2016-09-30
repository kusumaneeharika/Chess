using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.ConsoleApp
{
    class Rule
    {
       

        protected internal static bool Validate(int x, int y)
        {
            bool isValid = ((x >= 0) && (x <= 7) && (y >= 0) && (y <= 7));
            return isValid;
        }

        protected internal static bool DecrementY(ref Tuple<int,int> pPosition)
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

        protected internal static bool  IncrementY(ref Tuple<int, int> pPosition)
        {
            if (Validate(pPosition.Item1, pPosition.Item2 + 1))
            {
                pPosition = new Tuple<int, int>(pPosition.Item1, pPosition.Item2 + 1);
                return true;
            }
            else
                return false;
        }

        protected internal static bool DecrementX(ref Tuple<int, int> pPosition)
        {
            if (Validate(pPosition.Item1 - 1, pPosition.Item2 ))
            {
                pPosition = new Tuple<int, int>(pPosition.Item1 - 1, pPosition.Item2);
                return true;
            }
            else
                return false;
        }

        protected internal static bool IncrementX(ref Tuple<int, int> pPosition)
        {
            if (Validate(pPosition.Item1 + 1, pPosition.Item2))
            {
                pPosition = new Tuple<int, int>(pPosition.Item1 + 1, pPosition.Item2);
                return true;
            }
            else
                return false;
        }

      

        protected internal static bool KnightUpLeft(ref Tuple<int, int> pPosition)
        {
            if (DecrementY( ref pPosition) && DecrementY(ref pPosition) && DecrementX( ref pPosition))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected internal static bool KnightUpRight(ref Tuple<int, int> pPosition)
        {
            if ( DecrementY(ref pPosition) && DecrementY(ref pPosition) && IncrementX(ref pPosition) )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected internal static bool KnightDownLeft(ref Tuple<int,int> pPosition)
        {
            if (IncrementY(ref pPosition) && IncrementY(ref pPosition) && DecrementX(ref pPosition))
            {
                return true;
            }
            else
                return false;
        }

        protected internal static bool KnightLeftUp(ref Tuple<int,int> pPosition)
        {
            if (DecrementX(ref pPosition) && DecrementX(ref pPosition) && DecrementY(ref pPosition))
            {
                return true;
            }
            else
                return false;
        }

        protected internal static bool KnightLeftDown(ref Tuple<int,int> pPosition)
        {
            if (DecrementX(ref pPosition) && DecrementX(ref pPosition) && IncrementY(ref pPosition))
            {
                // check this part where any other piece exists here.
                return true;
            }
            else
                return false;
        }
        
        protected internal static bool KnightRightUp(ref Tuple<int, int> pPosition)
        {
            if (IncrementX(ref pPosition) && IncrementX(ref pPosition) && DecrementY(ref pPosition))
            {
                return true;
            }
            else
                return false;
        }

        protected internal static bool KnightRightDown(ref Tuple<int, int> pPosition)
        {
            if (IncrementX(ref pPosition) && IncrementX(ref pPosition) && IncrementY(ref pPosition))
            {
                return true;
            }
            else
                return false;
        }
    }
}
