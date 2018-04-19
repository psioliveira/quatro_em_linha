using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplexity
{
    public class Board
    {
        internal Block[,] block;
        

        // Constructors 

        public Board()
        {
            block = new Block[7, 7];
           int NextTurn = 1;    
            
        }
        

        // Getters
      
        public Block GetBlockPos (Position position)
        {
            return state[position.Row, position.Column];

        }


        // Setterrs 

        public bool SetBlockPos(Position position, Block newBlock)
        {
            if ( newBlock.belongsTo != NextTurn) return false;
            if (block[position.Row, position.Column].form != State.Undecided) return false;

            block[position.Row, position.Column] = newBlock;
            SwitchNextTurn(NewBlock);
            return true;

        }


        // Methods

            
        private void SwitchNextTurn( Block BlockPlaced)
        {
            if (BlockPlaced.color == "white")
            {
                NextTurn = 2;
            }

            if (BlockPlaced.color == "red")
            {
                NextTurn = 1;
            }

            else NextTurn = State.Undefined;
                
        }
    }

}
