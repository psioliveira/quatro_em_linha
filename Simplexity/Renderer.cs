﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplexity
{

    /// <summary>
    ///  Classe responsável por imprimir o Board na tela
    /// </summary>
    class Renderer
    {
        public void Render(Board board)
        {
            char[,] symbols = new char[7, 7]; // boar a ser impresso com letras e símbolos

            

            //procura e imprime cada valor das entradas do board
            for (int row = 0; row < 7; row++)
            {
                for (int column = 0; column < 7; column++)
                {
                    symbols[row, column] = SymbolFor(board.GetBlock(new Position(row, column)));
                    Console.Write($"{symbols[row, column]}  ");
                }
                //salta para a próxima linha ser escrita
                Console.WriteLine("");
            }
            Console.WriteLine("-------------------");
        }

        // metodo responsável por  determinar o símbolo de cada elemento no board
        private char SymbolFor(Block block)
        {
            char Char = '|';

            if (block.Color == "red")
            {
                if (block.Form == (int)Shape.cil)
                {
                    Char = 'r';
                }
                if (block.Form == (int)Shape.cub)
                {
                    Char = 'R';
                }
            }

            if (block.Color == "white")
            {
                if (block.Form == (int)Shape.cil)
                {
                    Char = 'w';
                }
                if (block.Form == (int)Shape.cub)
                {
                    Char = 'W';
                }
            }
            return Char;
        }

        //resultados sobre o vencedor a ser impresso no final do jogo
        public void RenderResults(int winner)
        {
            switch (winner)
            {
                case 1:
                case 2:

                    Console.WriteLine("Player" + winner + " Wins!");
                    break;

                case 0:
                    Console.WriteLine("Draw!");
                    break;
            }
        }
    }

}
