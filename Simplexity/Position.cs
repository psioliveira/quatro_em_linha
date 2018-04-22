using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplexity
{
    /// <summary>
    ///  Classe para gerar as posições dos objetos no board
    ///  
    /// </summary>
   
    class Position
    { 
        public int Row { get; set; } = 0 ;
        public int Column { get; set; } = 0;

        public Position(int row, int column)
        {
            Row = row;
            Column = column;
        }
    }

}
