using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplexity
{

    /// <summary>
    ///  Programa inicial onde são chamados os métodos e inicializados objetos
    ///  board é o tabuleiro do jogo
    ///  winChecker é o objeto com a responsabilidade de informar o vencedor ou um empate
    ///  renderer é a classe que imprime o tabuleiro no terminal de comandos
    /// </summary>
    

    public class Program
    {
        static void Main(string[] args)
        {
            //Gera cores

            //inicialização das instâncias do jogo

            Board board = new Board(); //criar novo board
            WinChecker winChecker = new WinChecker(); //checar win or draw
            Renderer renderer = new Renderer(); // renderizar board
            Player player1 = new Player(1); // criar player 1
            Player player2 = new Player(2); // criar player 2

            Position NextMove = new Position(0, 0); //posição para jogada 
            bool move = false; // flag para indicar se a jogada é válida ou não

            //enquanto NÃO for empate E enquanto NÃO houver vencedor definido, o ciclo continua
            while (winChecker.Check(board, player1, player2) == 0 && winChecker.IsDraw(board) == 0)
            {

                renderer.Render(board); //imprime, na linha de comandos, o tabuleiro atualizado



                if (board.NextTurn == 1) // caso o turno seja do jogador 1
                {
                    Console.WriteLine("Player 1"); //imprime o jogador
                    Console.WriteLine("\nEnter one Column between 1 and 7"); //solicita a coluna a jogar do tabuleiro


                    NextMove = player1.ColumnPlayed(board); // retorna uma posição válida para a jogada


                    Console.WriteLine("\nRow :" + NextMove.Row + "|| Col :" +
                                                       NextMove.Column + "\n"); // imprime linha e coluna da jogada
                    Console.WriteLine("\nSelect the piece what you want" +
                                " using num pad ( 1-> Square, 2->Circle )"); // solicita a peça a jogar


                    player1.PiecePlayed(); // seleciona a peça do player e decrementa o contador de peças
                    Console.WriteLine("\n"); // pula duas linhas

                    move = board.SetBlockBoard(NextMove, player1.Piece_played); // adiciona a peça no tabuleiro e retorna a flage caso não seja uma jogada possível

                }

                else if (board.NextTurn == 2)  // caso o turno seja do jogador 2
                {
                    Console.WriteLine("Player 2");//imprime o jogador
                    Console.WriteLine("\nEnter one Column between 1 and 7"); //solicita a coluna a jogar do tabuleiro

                    NextMove = player2.ColumnPlayed(board); // retorna uma posição válida para a jogada


                    Console.WriteLine("\nRow :" + NextMove.Row + "|| Col :"
                                                    + NextMove.Column + "\n"); // imprime linha e coluna da jogada
                    Console.WriteLine("\nSelect the piece what you want" +
                                   " using num pad ( 1-> Square, 2->Circle )"); // solicita a peça a jogar


                    player2.PiecePlayed(); // seleciona a peça do player e decrementa o contador de peças
                    Console.WriteLine("\n"); // pula duas linhas

                    move = board.SetBlockBoard(NextMove, player2.Piece_played); // adiciona a peça no tabuleiro e retorna a flage caso não seja uma jogada possível
                }
                Console.Clear(); // limpa tela

                if (move == false)
                    Console.WriteLine("\nThat is not a legal move.");
            }

            // após saír do ciclo, imprime o tabuleiro e os resultados do vencedor

            renderer.Render(board);  // mostra o board final
            renderer.RenderResults(winChecker.Check(board, player1, player2)); // mostra o vencedor

            // solicita uma tecla para terminar o programa
            Console.ReadKey();
        }
    }
}
