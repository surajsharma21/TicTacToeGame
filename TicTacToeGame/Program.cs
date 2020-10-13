﻿using System;

namespace TicTacToeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToeGame game = new TicTacToeGame();
            game.CreateBoard();
            char userChoice = game.Choice();
            game.ShowBoard();
            game.PlayerMovement(userChoice);
            game.Toss();
        }
    }
}
