using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplexity
{

    /// <summary>
    /// 
    /// </summary>
    class Block
    {
        //Shape and color properties (auto implemented)
        public int Form  { get; set; } = 0;
        public string Color { get; set; } = "";
        public int BelongsTo { get; private set; } = 0;

        // Constructors
        public Block(int form)
        {
            this.Form = form;
            Color = "";
            
        }

        // Methods

        public void Red()
        {
            Color = "red";
            BelongsTo = 1;
        }


        public void White()
        {
            Color = "White";
             BelongsTo = 2;
        }

    }

}
