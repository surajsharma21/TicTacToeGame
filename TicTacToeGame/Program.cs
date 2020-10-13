using System;

namespace TicTacToeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe!");
            TicTacToeGame game = new TicTacToeGame();
            game.CreateBoard();
        }
    }
}
