using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplexity
{
    public class WinChecker
    {
        public int Check(Board board)
        {
            if (CheckForWin(board, 1)) return player1.number;
            if (CheckForWin(board, 2)) return player2.number;
            return Shape.Undecided;
        }

        private bool CheckForWin(Board board, Shape player) //Por alterar tudo por completo
        {
            
        }

        private bool AreAll(Board board, Position[] positions, State state) //Por alterar tudo por completo
        {
            
        }



        public bool IsDraw(Board board)
        {
            for (int row = 0; row < 3; row++)
                for (int column = 0; column < 3; column++)
                    if (board.GetState(new Position(row, column)) == State.Undecided) return false;

            return true;
        }
    }
}
