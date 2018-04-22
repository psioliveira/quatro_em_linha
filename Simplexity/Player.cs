using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplexity
{

    /// <summary>
    /// Classe responsável por gerar os players, assim como os getters, setters construtores, 
    /// e métodos.
    /// </summary>
    class Player
    {
        //Instance Variables 

        private Block cube = new Block((int)Shape.cub); //square
        private Block cylinder = new Block((int)Shape.cil); //cylinder
        public Block Piece_played { get; private set; } = new Block((int)Shape.Undecided); //Usado para verificar jogada


        //Proprieties 

        
        public int Number { get; }
        public int Cube_count { get; private set; } = 11;
        public int Cylinder_count { get; private set; } = 10;

        //constructors 

        public Player(int Number)
        {
            this.Number = Number;

            if (Number == 1)
            {
                cube.White();
                cylinder.White();
                Piece_played.White();
            }

            if (Number == 2)
            {
                cube.Red();
                cylinder.Red();
                Piece_played.Red();
            }
        }

        // mehods

        public void PiecePlayed() // tipo de peça a posicionar
        {
            int p_type = 0;

            do
            {
                ConsoleKey playerGet = Console.ReadKey().Key;

                if (playerGet == ConsoleKey.NumPad1) //caso seja player 1
                {
                    Cube_count--;
                    Piece_played.Cil();
                    p_type = 1;
                    break;
                }

                if (playerGet == ConsoleKey.NumPad2) //caso seja player 2
                {
                    Cylinder_count--;
                    Piece_played.Cub();
                    p_type = 2;
                    break;
                }



                else
                {

                    Console.WriteLine("  Invalid Piece !!  : ");
                    Console.WriteLine("  Enter 1 for square and 2 for Circle.");

                }

            } while (p_type != 1 || p_type != 2);

        }



        public Position ColumnPlayed(Board board) //retorna posição a posicionar peça
        {
            int column_num = -1;
            int line = -1;
            int flag = 0;
            Position position;
            do
            {
                do
                {
                    column_num = -1;


                    switch (Console.ReadKey().Key) //devolve o numero da coluna a jogar
                    {
                        case ConsoleKey.NumPad1:
                            column_num = 0;
                            break;
                        case ConsoleKey.NumPad2:
                            column_num = 1;
                            break;
                        case ConsoleKey.NumPad3:
                            column_num = 2;
                            break;
                        case ConsoleKey.NumPad4:
                            column_num = 3;
                            break;
                        case ConsoleKey.NumPad5:
                            column_num = 4;
                            break;
                        case ConsoleKey.NumPad6:
                            column_num = 5;
                            break;
                        case ConsoleKey.NumPad7:
                            column_num = 6;
                            break;

                        default:
                            Console.WriteLine("  Invalid Column !!");
                            Console.WriteLine("  Enter one number between 1 and 7 for columns.");
                            column_num = -1;
                            break;
                    }


                } while (column_num == -1);



                for (int i = 6; i >= 0; i--) //procura o primeiro espaço vazio na coluna
                {
                    position = new Position(i, column_num);
                    if ((Shape)board.GetBlock(position).Form == Shape.Undecided)
                    {
                        line = i;
                        flag = 1;
                        break;
                    }
                }

                if (flag == 0) //caso não encontre
                {
                    Console.WriteLine("This Column is already full, please choose a diferent column.");
                    column_num = -1;
                }

            } while (column_num == -1); //volta a solicitar uma coluna

            position = new Position(line, column_num);

            return position; //retorna posição desejada para a jogada
        }


    }
}

