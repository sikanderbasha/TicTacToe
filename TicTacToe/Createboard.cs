using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Createboard
    {
        public void Create()
        {
            char[] board = new char[10];       
            for (int StartPoint = 0; StartPoint < board.Length; StartPoint++) 
                Console.WriteLine(board[StartPoint]); 
        }
    }
}
