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

        private Block cube = new Block() { form = 0 };
        private Block cylinder = new Block() { form = 1 };


        //Proprieties 

        private int cube_count { get;  private set; } = 11;
        private int cylinder_count { get; private set; } = 10;
        //constructors

        public Player(Block cube, Block cylinder)
        {
            this.cube = cube;
            this.cylinder = cylinder;

        }
    }
}
