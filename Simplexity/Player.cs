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

        private Block cube = new Block(Shape.cub); //square
        private Block cylinder = new Block(Shape.cil); //cylinder
        private int number;
        private Block piece_played = new Block(Shape.Undecided); //Usado para verificar jogada
            

        //Proprieties 

        public int Cube_count { get; private set; } = 11;
        public int Cylinder_count { get; private set; } = 10;

        //constructors 

        public Player(int number)
        {
            this.number = number;

            if (number == 1)
            {
                cube.White();
                cylinder.White();
            }

            if (number == 2)
            {
                cube.Red();
                cylinder.Red();
                
            }
        }

        //verifica onde vai adicionar a peça no tabuleiro e se a mesma entrada está vazia    
        //
        public Position GetPosition (Board board)
         {
            int piece_type = (int)Console.ReadKey();
            int column_num = (int)Console.ReadKey(); 
            for (i= 6; i >= 0; i--)
7           {
               if( board[i,column_num].Form == 0)
                    return Position(i, column_num);
               //add piece 

            }
        }
        public void Piece_played(Block blockp)
        {
            //Swap turn
            
            //Scan current turn's piece
            private int current_play;
            current_play ;
            
        }
    }
}
