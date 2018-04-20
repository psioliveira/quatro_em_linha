using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplexity
{
    class Player
    {
        //Instance Variables 

        private Block cube = new Block((int)Shape.cub); //square
        private Block cylinder = new Block((int)Shape.cil); //cylinder
        public int Number { get; }
        private Block piece_played = new Block((int)Shape.Undecided); //Usado para verificar jogada


        //Proprieties 

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
            }

            if (Number == 2)
            {
                cube.Red();
                cylinder.Red();

            }
        }

        // mehods

        public int PiecePlayed(int piece_type)
        {

            do
            {

                if (piece_type != 1 || piece_type != 2)
                {
                    Console.WriteLine("  Invalid Piece !!");
                    Console.WriteLine("  Enter 1 for square and 2 for Cylnder.");
                    piece_type = Convert.ToInt32(Console.ReadKey());
                }

            } while (piece_type == 0);

            return piece_type;

        }



        public Position ColumnPlayed(Board board)
        {
            int column_num = -1;
            int line = -1;
            int flag = 0;
            Position position;
            do
            {
                do
                {
                    column_num = Convert.ToInt32(Console.ReadKey());
                    column_num--;
                    if (column_num < 0 || column_num > 6)
                    {
                        Console.WriteLine("  Invalid clumn !!");
                        Console.WriteLine("  Enter one Column between 1 and 7.");
                        column_num = -1;

                    }

                } while (column_num == -1);



                for (int i = 6; i >= 0; i--)
                {
                    position = new Position(i, column_num);
                    if ((Shape)board.GetBlockPos(position).Form == Shape.Undecided)
                    {
                        line = i;
                        flag = 1;
                        break;
                    }
                }

                if (flag == 0)
                {
                    Console.WriteLine("This Column is already full, please choose a diferent column.");
                    column_num = -1;
                }

            } while (column_num == -1);

            position = new Position(line, column_num);

            return position;
        }


    }
}

