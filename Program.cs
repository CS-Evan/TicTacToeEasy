using System.Linq;
namespace TicTacToeEasy;

class Program
{
    static public int check = 0;
    
    static public bool continueGame = false;
    static public bool gameWin = false;

    static void Main(string[] args)
    {
        Random r = new Random();
        
        // Introduction
        Console.WriteLine("********************************");
        Console.WriteLine("* WELCOME TO TIC TAC TOE vs AI *");
        Console.WriteLine("*         VERSION 1.00         *");
        Console.WriteLine("********************************");
        Console.WriteLine();
        Console.WriteLine("The AI is very simple. If the program won't progress, type STUCK to force a draw.\n");

        // CoinFlip to see who goes first
        int coinFlip = r.Next(1, 3);
        Console.WriteLine("Coin Flip! If 1 - Player goes first ; If 2 - PC goes first: " + coinFlip + "\n");

        if(coinFlip == 1)
        {
            Console.WriteLine("As the coin flip was 1, you will go first!\n");
            Thread.Sleep(1000);
            GameBoard.Board();
            PlayerLogic.Player();
        }
        else
        {
            Console.WriteLine("As the coin flip was 2, the computer will go first!\n");
            check = 1;
            Thread.Sleep(2000);
            AiLogic.PC();
        }

        //Start and Win/Draw Checker
        WinLogic.Draw();        
    }
}




