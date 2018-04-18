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
        public bool form  { get; set; }
        public string color { get; set; } = "";

        // Constructors
        public Block(bool form)
        {
            this.form = form;
            color = "";
            
        }

        // Methods

        public void Red()
        {
            color = "red";
        }


        public void White()
        {
            color = "White";
        }

    }

}
