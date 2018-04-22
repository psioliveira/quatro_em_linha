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
    class Board
    {
        private Block[,] board;
        public int NextTurn { get; set; } = 1;


        // Constructors 

        public Board()
        {
            board = new Block[7, 7]
            {
                { new Block(0), new Block(0), new Block(0), new Block(0), new Block(0), new Block(0), new Block(0) },
                { new Block(0), new Block(0), new Block(0), new Block(0), new Block(0), new Block(0), new Block(0) },
                { new Block(0), new Block(0), new Block(0), new Block(0), new Block(0), new Block(0), new Block(0) },
                { new Block(0), new Block(0), new Block(0), new Block(0), new Block(0), new Block(0), new Block(0) },
                { new Block(0), new Block(0), new Block(0), new Block(0), new Block(0), new Block(0), new Block(0) },
                { new Block(0), new Block(0), new Block(0), new Block(0), new Block(0), new Block(0), new Block(0) },
                { new Block(0), new Block(0), new Block(0), new Block(0), new Block(0), new Block(0), new Block(0) },
            };

        }

        // Methods




        public Block GetBlock(Position position)
        {
            return board[position.Row, position.Column];
        }


        public bool SetBlockBoard(Position position, Block NewBlock)
        {
            {
                if (NewBlock.BelongsTo != NextTurn && NewBlock.BelongsTo != 0) // caso a peça já tenha sido alterada
                {
                    Console.WriteLine("ret1");
                    return false;
                }
                if (board[position.Row, position.Column].Form != 0) // caso a posição já contenha peça
                {
                    Console.WriteLine("ret2");
                    return false;
                }
                if (position.Row >= 7 || position.Column >= 7) // caso a posição esteja fora do board
                {
                    Console.WriteLine("ret3");
                    return false;
                }
                if (position.Row < 0 || position.Column < 0) // caso a posição esteja fora do board
                {

                    Console.WriteLine("Row :" + position.Row + "|| Col :" + position.Column);
                    Console.WriteLine("ret4");
                    return false;
                }

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
