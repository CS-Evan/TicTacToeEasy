using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeEasy;

namespace LogicClasses
{

    public class PlayerLogic
    {
        public static void Player()
        {

            string input;
            bool continueGame = false;


            GameBoard gboard = new GameBoard();
            Program p = new Program();
            
            // Logic for player actions
            if (WinLogic.gameWin == false)
            {
                do
                {
                    Console.Write("Where would you like to place an X: ");
                    input = Console.ReadLine().ToUpper();
                    Console.WriteLine();
                    if (input == "1" && GameBoard.matrix[0, 0] != "O" && GameBoard.matrix[0, 0] != "X")
                    {
                        GameBoard.matrix[0, 0] = "X";
                        continueGame = true;
                    }
                    else if (input == "2" && GameBoard.matrix[0, 1] != "O" && GameBoard.matrix[0, 1] != "X")
                    {
                        GameBoard.matrix[0, 1] = "X";
                        continueGame = true;
                    }
                    else if (input == "3" && GameBoard.matrix[0, 2] != "O" && GameBoard.matrix[0, 2] != "X")
                    {
                        GameBoard.matrix[0, 2] = "X";
                        continueGame = true;
                    }
                    else if (input == "4" && GameBoard.matrix[1, 0] != "O" && GameBoard.matrix[1, 0] != "X")
                    {
                        GameBoard.matrix[1, 0] = "X";
                        continueGame = true;
                    }
                    else if (input == "5" && GameBoard.matrix[1, 1] != "O" && GameBoard.matrix[1, 1] != "X")
                    {
                        GameBoard.matrix[1, 1] = "X";
                        continueGame = true;
                    }
                    else if (input == "6" && GameBoard.matrix[1, 2] != "O" && GameBoard.matrix[1, 2] != "X")
                    {
                        GameBoard.matrix[1, 2] = "X";
                        continueGame = true;
                    }
                    else if (input == "7" && GameBoard.matrix[2, 0] != "O" && GameBoard.matrix[2, 0] != "X")
                    {
                        GameBoard.matrix[2, 0] = "X";
                        continueGame = true;
                    }
                    else if (input == "8" && GameBoard.matrix[2, 1] != "O" && GameBoard.matrix[2, 1] != "X")
                    {
                        GameBoard.matrix[2, 1] = "X";
                        continueGame = true;
                    }
                    else if (input == "9" && GameBoard.matrix[2, 2] != "O" && GameBoard.matrix[2, 2] != "X")
                    {
                        GameBoard.matrix[2, 2] = "X";
                        continueGame = true;
                    }
                    else if (input == "STUCK")
                    {
                        Console.WriteLine("Forcing exit due to issue(Command STUCK was entered).");
                        Environment.Exit(0);

                    }
                    else if (input != "1" && input != "2" && input != "3" && input != "4" && input != "5" && input != "6" && input != "7" && input != "8" && input != "9")
                    {
                        Console.WriteLine("Input must be a number from 1-9 a Try again.\n");
                        continueGame = false;
                    }

                    else
                    {
                        Console.WriteLine("Cannot place X as spot is filled. Try again.\n");
                        continueGame = false;
                    }
                    GameBoard.Board();
                    WinLogic.PlayerWinCheck();
                } while (continueGame == false);


                if (WinLogic.gameWin == false)
                {
                    Program.check++;
                    AiLogic.PC();
                }
                else
                {

                }
            }
        }


    }
}
