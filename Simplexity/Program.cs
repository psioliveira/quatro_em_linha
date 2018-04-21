﻿using System;
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
            while (winChecker.Check(board, player1, player2) == 0 && winChecker.IsDraw (board) == 0 )
            {
                //imprime, na linha de comandos, o tabuleiro atualizado
                renderer.Render(board);

                Position NextMove = new Position(0, 0);

                if (board.NextTurn == 1)
                {
                    Console.WriteLine("Give the piece what you want (1-> Square, 2->Circle");
                    int piece = player1.PiecePlayed();



                    Console.WriteLine("Enter one Column between 1 and 7");
                    NextMove = player1.ColumnPlayed(board);
                }

                if (board.NextTurn == 2)
                {
                    Console.WriteLine("Give the piece what you want (1-> Square, 2->Circle");
                    int piece = player2.PiecePlayed();

                    Console.WriteLine("Enter one Column between 1 and 7");
                    NextMove = player2.ColumnPlayed(board);
                }
                if (!board.SetBlockBoard(NextMove, board.GetBlock(NextMove)))
                    Console.WriteLine("That is not a legal move.");
            }

            // após saír do ciclo, imprime o tabuleiro e os resultados do vencedor
            renderer.Render(board);
            renderer.RenderResults( winChecker.Check(board, player1, player2) );

            // solicita uma tecla para terminar o programa
            Console.ReadKey();
        }
    }
}
