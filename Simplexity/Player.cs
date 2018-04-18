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

        private Block cube = new Block(false); //square
        private Block cylinder = new Block(true); //cylinder


        //Proprieties 

        public int Cube_count { get; private set; } = 11;
        public int Cylinder_count { get; private set; } = 10;

        //constructors 

        public Player(int number)
        {
            if (number == 1)
            {
                cube.Red();
                cylinder.Red();
            }

            if (number == 2)
            {
                cube.White();
                cylinder.White();
            }
        }

        //Methods

        public void Piece_payed()
        {


        }
    }
}
