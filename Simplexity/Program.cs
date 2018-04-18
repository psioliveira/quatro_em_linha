using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplexity
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Gera cores
            
            //inicialização das instâncias do jogo
            Board board = new Board();
            WinChecker winChecker = new WinChecker();
            Renderer renderer = new Renderer();
            Player player1 = new Player();
            Player player2 = new Player();

            //enquanto NÃO for empate E enquanto NÃO houver vencedor definido, o ciclo continua
            while (!winChecker.IsDraw(board) && winChecker.Check(board) == State.Undecided)
            {
                //imprime, na linha de comandos, o tabuleiro atualizado
                renderer.Render(board);

                Position nextMove;
                if (board.NextTurn == State.X)
                    nextMove = player1.GetPosition(board);
                else
                    nextMove = player2.GetPosition(board);

                if (!board.SetState(nextMove, board.NextTurn))
                    Console.WriteLine("That is not a legal move.");
            }

            //após saír do ciclo, imprime o tabuleiro e os resultados do vencedor
            renderer.Render(board);
            renderer.RenderResults(winChecker.Check(board));

            //solicita uma tecla para terminar o programa
            Console.ReadKey();
        }
    }
}
