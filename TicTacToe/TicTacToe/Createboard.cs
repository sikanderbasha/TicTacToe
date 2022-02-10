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
            for (int StartingIndex = 0; StartingIndex < board.Length; StartingIndex++) 
                Console.WriteLine(board[StartingIndex] = ' '); 
        }
    }
}
