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
            
            Board board = new Board(); //criar novo board
            WinChecker winChecker = new WinChecker(); //checar win or draw
            Renderer renderer = new Renderer(); // renderizar board
            Player player1 = new Player(1); //set player 1
            Player player2 = new Player(2); //set player 2

            //enquanto NÃO for empate E enquanto NÃO houver vencedor definido, o ciclo continua
            while (!winChecker.IsDraw(board) && winChecker.Check(board) == 0)
            {
                //imprime, na linha de comandos, o tabuleiro atualizado
                renderer.Render(board);

                Position NextMove = new Position(0,0);
                
                if (board.NextTurn == 1)
                    NextMove = player1.GetPosition(board);
                if (board.NextTurn == 2)
                    NextMove = player2.GetPosition(board);

                if (!board.SetBlock(NextMove, board.NextTurn))
                    Console.WriteLine("That is not a legal move.");
            }

            // após saír do ciclo, imprime o tabuleiro e os resultados do vencedor
            renderer.Render(board);
            renderer.RenderResults(winChecker.Check(board));

            // solicita uma tecla para terminar o programa
            Console.ReadKey();
        }
    }
}
