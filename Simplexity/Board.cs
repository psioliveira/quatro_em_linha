using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplexity
{
    class Board
    {
        private Block[,] board;
        public int NextTurn { get; set; } = 1;

 
        // Constructors 

        public Board()
        {
            board = new Block[7, 7];
        }

<<<<<<< HEAD
        // Getters
      
        private Block GetBlockPos (Position position)
        {
            return state[position.Row, position.Column];
=======
>>>>>>> feb87ccd1b8cd529e4eeb41be897d8ecdfd0b5f4


        // Methods


        public Block GetBlockBoard (Position position)
        {
            return board[position.Row, position.Column];
        }


        public bool SetBlockBoard(Position position, Block NewBlock)
        {
            {
                if (NewBlock.BelongsTo != NextTurn) return false;
                if (board[position.Row, position.Column].Form != 0) return false;

                board[position.Row, position.Column] = NewBlock;
                SwitchNextTurn(NewBlock);
                return true;
            }
        }



        private void SwitchNextTurn(Block BlockPlaced)
        {
            if (BlockPlaced.Color == "white")
            {
                NextTurn = 2;
            }

            if (BlockPlaced.Color == "red")
            {
                NextTurn = 1;
            }

            else NextTurn = 0;

        }
    }

}
