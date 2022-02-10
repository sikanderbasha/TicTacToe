using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe");
            CreateBoard create = new CreateBoard();
            create.Create();
            Console.ReadKey();
        }
    }
}
