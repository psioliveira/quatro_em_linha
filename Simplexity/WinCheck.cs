using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplexity
{
    class WinChecker


    {
        public int Check(Board board, Player player1, Player player2)
        {
            if (CheckWin(board) == 1) return player1.Number;
            if (CheckWin(board) == 2) return player2.Number;

            return ((int)Shape.Undecided);
        }

        public int CheckWin(Board board)
        {



            for (int row = 0; row < 4; row++)
            {
                for (int column = 0; column < 4; column++)
                {
                    // posições na horizontal
                    Position pos1 = new Position(row, column);
                    Position pos2 = new Position(row, column + 1);
                    Position pos3 = new Position(row, column + 2);
                    Position pos4 = new Position(row, column + 3);
                    int flag = 0; //flag que altera entre direções e sai do loop no final

                    do // loop para alterar a direção da busca das 4 peças 
                    {
                        if ((board.GetBlock(pos1)).Form == ((int)Shape.cil) &&
                            (board.GetBlock(pos2)).Form == ((int)Shape.cil) &&
                            (board.GetBlock(pos3)).Form == ((int)Shape.cil) &&
                            (board.GetBlock(pos4)).Form == ((int)Shape.cil))
                        {
                            return 1; // retorna caso o vencedor seja o player 1
                        }


                        if ((board.GetBlock(pos1)).Color == ("white") &&
                            (board.GetBlock(pos2)).Color == ("white") &&
                            (board.GetBlock(pos3)).Color == ("white") &&
                            (board.GetBlock(pos4)).Color == ("white"))
                        {
                            return 1; // retorna caso o vencedor seja o player 1
                        }

                        if ((board.GetBlock(pos1)).Form == ((int)Shape.cub) &&
                            (board.GetBlock(pos2)).Form == ((int)Shape.cub) &&
                            (board.GetBlock(pos3)).Form == ((int)Shape.cub) &&
                            (board.GetBlock(pos4)).Form == ((int)Shape.cub))
                        {
                            return 2; // retorna caso o vencedor seja o player 2
                        }


                        if ((board.GetBlock(pos1)).Color == ("red") &&
                            (board.GetBlock(pos2)).Color == ("red") &&
                            (board.GetBlock(pos3)).Color == ("red") &&
                            (board.GetBlock(pos4)).Color == ("red"))
                        {
                            return 2; // retorna caso o vencedor seja o player 2
                        }

                        flag += 1; //flag que altera entre direções e sai do loop no final

                        if (flag == 1) // posições na vertical
                        {
                            pos1 = new Position(row, column);
                            pos2 = new Position(row + 1, column);
                            pos3 = new Position(row + 2, column);
                            pos4 = new Position(row + 3, column);
                        }

                        if (flag == 2) // posições na diagonal
                        {
                            pos1 = new Position(row, column);
                            pos2 = new Position(row + 1, column + 1);
                            pos3 = new Position(row + 2, column + 2);
                            pos4 = new Position(row + 3, column + 3);
                        }
                        
                    } while (flag != 3);
                }
            }


            for (int row = 0; row < 4; row++)
            {
                for (int column = 6; column >= 0; column--)
                // posições na diagonal inversa
                {
                    Position pos1 = new Position(row, column);
                    Position pos2 = new Position(row + 1, column - 1);
                    Position pos3 = new Position(row + 2, column - 2);
                    Position pos4 = new Position(row + 3, column - 3);


                    if ((board.GetBlock(pos1)).Form == ((int)Shape.cil) &&
                        (board.GetBlock(pos2)).Form == ((int)Shape.cil) &&
                        (board.GetBlock(pos3)).Form == ((int)Shape.cil) &&
                        (board.GetBlock(pos4)).Form == ((int)Shape.cil))
                    {
                        return 1; // retorna caso o vencedor seja o player 1
                    }


                    if ((board.GetBlock(pos1)).Color == ("white") &&
                        (board.GetBlock(pos2)).Color == ("white") &&
                        (board.GetBlock(pos3)).Color == ("white") &&
                        (board.GetBlock(pos4)).Color == ("white"))
                    {
                        return 1; // retorna caso o vencedor seja o player 1
                    }

                    if ((board.GetBlock(pos1)).Form == ((int)Shape.cub) &&
                        (board.GetBlock(pos2)).Form == ((int)Shape.cub) &&
                        (board.GetBlock(pos3)).Form == ((int)Shape.cub) &&
                        (board.GetBlock(pos4)).Form == ((int)Shape.cub))
                    {
                        return 2; // retorna caso o vencedor seja o player 2
                    }


                    if ((board.GetBlock(pos1)).Color == ("red") &&
                        (board.GetBlock(pos2)).Color == ("red") &&
                        (board.GetBlock(pos3)).Color == ("red") &&
                        (board.GetBlock(pos4)).Color == ("red"))
                    {
                        return 2; // retorna caso o vencedor seja o player 2
                    }
                }

            }


            return 0; //retorna caso não tenha vencedor
        }


    }
}
