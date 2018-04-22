using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplexity
{

    /// <summary>
    ///  Clase responsável pelo board, inicialização das variáveis, construtores ,
    ///  getters e setters do board, assim como dos metodos.
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

        //methods

        public Block GetBlock(Position position)
        {
            return board[position.Row, position.Column];
        }


        public bool SetBlockBoard(Position position, Block NewBlock)
        {
            
            {
                if (NewBlock.BelongsTo != NextTurn && NewBlock.BelongsTo != 0) // caso a peça já tenha sido alterada
                {return false;}

                if (board[position.Row, position.Column].Form != 0) // caso a posição já contenha peça
                {return false;}

                if (position.Row >= 7 || position.Column >= 7) // caso a posição esteja fora do board
                { return false;}

                if (position.Row < 0 || position.Column < 0) // caso a posição esteja fora do board
                {return false;}
                Block New_Block = new Block(NewBlock.Form,NewBlock.Clr());

                board[position.Row, position.Column] = New_Block;

                SwitchNextTurn(New_Block);
                
                return true;
            }
        }



        private void SwitchNextTurn(Block BlockPlaced) //altera entre turno player 1 e player 2
        {
            if (BlockPlaced.BelongsTo == 1 )
            {
                NextTurn = 2;
            }

            if (BlockPlaced.BelongsTo == 2)
            {
                NextTurn = 1;
            }
        }
    }

}
