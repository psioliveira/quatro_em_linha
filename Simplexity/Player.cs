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

        //Methods   

        public void Piece_payed()
        {


        }
    }
}
