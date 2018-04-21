﻿using System;
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
            board = new Block [7, 7];
        }

        // Methods




        public Block GetBlock (Position position)
        {
            return board[position.Row, position.Column];
        }


        public bool SetBlockBoard(Position position, Block NewBlock)
        {
            {
                if (NewBlock.BelongsTo != NextTurn) return false;
                if (board[position.Row, position.Column].Form != 0) return false;
                if (position.Row >=7 || position.Column >= 7) return false;
                if (position.Row <= 0 || position.Column <= 0) return false;

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
