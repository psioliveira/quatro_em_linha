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

        private bool CheckForWin(Board board, Shape player) //Por alterar com maior cuidado
        {
            for (int row = 0; row < 3; row++)
                if (AreAll(board, new Position[] {
                        new Position(row, 0),
                        new Position(row, 1),
                        new Position(row, 2) }, player))
                    return true;

            for (int column = 0; column < 3; column++)
                if (AreAll(board, new Position[] {
                        new Position(0, column),
                        new Position(1, column),
                        new Position(2, column) }, player))
                    return true;

            if (AreAll(board, new Position[] {
                    new Position(0, 0),
                    new Position(1, 1),
                    new Position(2, 2) }, player))
                return true;

            if (AreAll(board, new Position[] {
                    new Position(2, 0),
                    new Position(1, 1),
                    new Position(0, 2) }, player))
                return true;

            return false;
        }

        private bool AreAll(Board board, Position[] positions, State state)
        {
            foreach (Position position in positions)
                if (board.GetState(position) != state) return false;

            return true;
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
