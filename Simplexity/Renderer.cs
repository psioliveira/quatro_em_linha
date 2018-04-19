using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplexity
{
    public class Renderer
    {
        public void Render(Board board)
        {
            char[,] symbols = new char[7, 7];


            for (int row = 0; row < 7; row++)
            {
                for (int column = 0; column < 7; column++)
                {
                    symbols[row, column] = SymbolFor(board.GetState(new Position(row, column)));
                    Console.Write($"{symbols[row, column]}  ");
                }
                //salta para a próxima linha ser escrita
                Console.WriteLine("");
            }
            Console.WriteLine("-------------------");
        }

        private char SymbolFor(Shape shape)
        {
            switch (shape)
            {
                case Shape.cub: 
                {
                return 'W';

                }
               
                case Shape.w: return 'w';
               
                case State.Undecided: return '|';
                default: return ' ';
            }
        }

        public void RenderResults(State winner)
        {
            switch (winner)
            {
                case State.W:
                case State.R:
                case State.w:
                case State.r:
                    Console.WriteLine(SymbolFor(winner) + " Wins!");
                    break;

                case State.Undecided:
                    Console.WriteLine("Draw!");
                    break;
            }
        }
    }

}
