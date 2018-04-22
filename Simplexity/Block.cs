using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplexity
{

    /// <summary>
    /// Classe responsável pela criação das peças, assim como  seus 
    /// consstrutores, getters, setters e métodos.
    /// </summary>
    class Block
    {
        //Shape and color properties (auto implemented)
        public int Form  { get; private set; } = 0;
        public string Color { get;  private set; } = "";
        public int BelongsTo { get; private set; } = 0;
        
        // Constructors

        public Block(int form)
        {
            this.Form = form;
            Color = "";
            
        }
        public Block(int form, int color)
        {
            this.Form = form;
            if (color == 2)
                Red();

            if (color == 1)
                White();

        }

        // Methods

        public void Red()
        {
            Color = "red";
            BelongsTo = 2;
        }


        public void White()
        {
            Color = "white";
             BelongsTo = 1;
        }

        public void Cub()
        {
            Form = (int)Shape.cub;
        }

        public void Cil()
        {
            Form = (int)Shape.cil;
        }

        public int Clr()
        {
            if (Color == "white") return 1;
            else if (Color == "red") return 2;
            else return 0;
        }
    }

}
