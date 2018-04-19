using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplexity
{
    class Block
    {
        //Shape and color properties (auto implemented)
        public int form  { get; set; } = Shape.Undecided;
        public string color { get; set; } = "";
        public int belongsTo {get; private set;} = Shape.Undecided = "";

        // Constructors
        public Block(int form)
        {
            this.form = form;
            color = "";
            
        }

        // Methods

        public void Red()
        {
            color = "red";
            belongsTo = 1;
        }


        public void White()
        {
            color = "White";
             belongsTo = 2;
        }

    }

}
