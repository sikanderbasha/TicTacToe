using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class CreateBoard
    {
        public void Create()
        {
            char[] board = new char[10];
            for (int StartPoint = 0; StartPoint < board.Length; StartPoint++)
                board[StartPoint] = ' ';
        }

        
    }
}
