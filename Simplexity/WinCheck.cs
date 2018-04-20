using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplexity
{
    public class WinChecker
    {
        public int Check(Board board,Player player1, Player player2)
        {
            if (CheckForWin(board, Shape.cub)) return player1.Number;
            if (CheckForWin(board, Shape.cil)) return player2.Number;
            return ((int)Shape.Undecided);
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
