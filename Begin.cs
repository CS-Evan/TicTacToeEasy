using LogicClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeEasy
{
    public class Begin
    {
        void BeginProgram()
        {
            // Vari
            Random r = new Random();

            // Introduction
            Console.WriteLine("********************************");
            Console.WriteLine("* WELCOME TO TIC TAC TOE vs AI *");
            Console.WriteLine("*         VERSION 1.00         *");
            Console.WriteLine("********************************");
            Console.WriteLine();

            // CoinFlip to see who goes first
            int coinFlip = r.Next(1, 3);
            Console.WriteLine("Coin Flip! If 1 - Player goes first ; If 2 - PC goes first: " + coinFlip + "\n");

            if (coinFlip == 1)
            {
                Console.WriteLine("As the coin flip was 1, you will go first!\n");
                Thread.Sleep(1000);
                GameBoard.Board();
                PlayerLogic.Player();
            }
            else
            {
                Console.WriteLine("As the coin flip was 2, the computer will go first!\n");
                Thread.Sleep(1000);
                AiLogic.PC();
            }
        }
    }
}
