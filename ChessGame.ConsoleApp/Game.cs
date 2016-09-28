using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.ConsoleApp
{
   public class Game
    {
        Board board = new Board();

        #region Public Methods
        public bool Move(bool isWhite, string src, string dst)
        {
            if (src.Contains("a"))
            {

            }
           else if (src.Contains("b"))
            {

            }
            else if (src.Contains("c"))
            {

            }
            else if (src.Contains("d"))
            {

            }
            else if (src.Contains("e"))
            {

            }
            else if (src.Contains("f"))
            {

            }
            else if (src.Contains("g"))
            {

            }
            else if (src.Contains("g"))
            {

            }
            return true;
        }

        public void Undo()
        {

        }
        #endregion Public Methods

    }
}
