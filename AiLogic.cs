using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeEasy
{
    public class AiLogic
    {
        static public bool aiDraw = false;
        static public void PC()
        {
            Random r = new Random();
            bool pcRepeat = true;
            if (Program.check >= 9)
            {
                aiDraw = true;
                Console.WriteLine("Game is a DRAW");
                Console.WriteLine("Thanks for playing!");
                WinLogic.stop = true;
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\nComputer is playing\n");
                Thread.Sleep(1000);
                do
                {                   
                    // Does random num check to figure out where to go.
                    int num1 = r.Next(0, 3);
                    int num2 = r.Next(0, 3);                   
                    if (GameBoard.matrix[1, 1] != "X" && GameBoard.matrix[1, 1] != "O")
                    {
                        GameBoard.matrix[1, 1] = "O";
                        pcRepeat = false;
                    }
                    else if (GameBoard.matrix[num1, num2] != "X" && GameBoard.matrix[num1, num2] != "O")
                    {
                        Console.WriteLine("The Computer has decided the next move.\n");
                        GameBoard.matrix[num1, num2] = "O";
                        pcRepeat = false;
                    }
                    else
                    {
                        Console.Write("Computer is thinking");                      
                        Thread.Sleep(200);
                        Console.Write(".");
                        Thread.Sleep(200);
                        Console.Write(".");
                        Thread.Sleep(200);
                        Console.Write(".");
                        Thread.Sleep(200);
                        Console.WriteLine("\n");
                        num1 = r.Next(0, 2);
                        num2 = r.Next(0, 2);
                    }                   
                    WinLogic.PCWINCheck();
                } while (pcRepeat == true && WinLogic.stop == false);               
                Program.check++;
                GameBoard.Board();
            }
        }
    }
}
