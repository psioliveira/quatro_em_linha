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


        // Getters

        private Block GetBlockPos(Position position)
        {
            return board[position.Row, position.Column];
        }




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
