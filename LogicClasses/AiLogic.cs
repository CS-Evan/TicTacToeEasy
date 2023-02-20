using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeEasy;

namespace LogicClasses
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
                Console.WriteLine("Thanks for playing! Press ENTER to quit.");
                WinLogic.stop = true;
                Console.ReadKey();
            }
            else
            {
                int counter_ = 0;
                Console.WriteLine("\nComputer is playing\n");
                Thread.Sleep(1000);
                do
                {
                    // Does random num check to figure out where to go.
                    int num1 = r.Next(0, 3);
                    int num2 = r.Next(0, 3);
                    int rng = r.Next(1, 3);
                    
                    if (rng == 1 && GameBoard.matrix[1, 1] != "X" && GameBoard.matrix[1, 1] != "O")
                    {                      
                        Waiting();
                        GameBoard.matrix[1, 1] = "O";
                        pcRepeat = false;                        
                    }
                    // Battles
                    else if (GameBoard.matrix[0, 0] == "X" && GameBoard.matrix[0, 1] == "X" && GameBoard.matrix[0, 2] != "X" && GameBoard.matrix[0, 2] != "O")
                    {
                        Waiting();
                        GameBoard.matrix[0, 2] = "O";
                        pcRepeat = false;
                    }
                    else if (rng == 2 && GameBoard.matrix[0, 0] == "X" && GameBoard.matrix[0, 2] == "X" && GameBoard.matrix[0, 1] != "X" && GameBoard.matrix[0, 1] != "O")
                    {
                        Waiting();
                        GameBoard.matrix[0, 1] = "O";
                        pcRepeat = false;
                    }
                    else if (GameBoard.matrix[0, 0] == "X" && GameBoard.matrix[1, 0] == "X" && GameBoard.matrix[2, 0] != "X" && GameBoard.matrix[2,0] != "O")
                    {
                        Waiting();
                        GameBoard.matrix[2,0] = "O";
                        pcRepeat = false;
                    }
                    else if (rng == 2 && GameBoard.matrix[1,0] == "X" && GameBoard.matrix[2, 0] == "X" && GameBoard.matrix[0, 0] != "X" && GameBoard.matrix[0, 0] != "O")
                    {
                        Waiting();
                        GameBoard.matrix[0, 0] = "O";
                        pcRepeat = false;
                    }
                    else if (rng == 1 && GameBoard.matrix[0, 0] == "X" && GameBoard.matrix[2, 0] == "X" && GameBoard.matrix[1, 0] != "X" && GameBoard.matrix[1, 0] != "O")
                    {
                        Waiting();
                        GameBoard.matrix[1, 0] = "O";
                        pcRepeat = false;
                    }
                    //Top left to Bottom Right
                    else if (GameBoard.matrix[0,0] == "O" && GameBoard.matrix[1,1] == "O" && GameBoard.matrix[2, 2] != "X" && GameBoard.matrix[2, 2] != "O") {
                        Waiting();
                        GameBoard.matrix[2,2] = "O";
                        pcRepeat = false;
                    }
                    else if(GameBoard.matrix[2,2] == "O" && GameBoard.matrix[1,1] == "O" && GameBoard.matrix[0, 0] != "X" && GameBoard.matrix[0, 0] != "O")
                    {
                        Waiting();
                        GameBoard.matrix[0,0] = "O";
                        pcRepeat = false;
                    }
                    else if (GameBoard.matrix[2, 2] == "O" && GameBoard.matrix[0,0] == "O" && GameBoard.matrix[1, 1] != "X" && GameBoard.matrix[1, 1] != "O")
                    {
                        Waiting();
                        GameBoard.matrix[1,1] = "O";
                        pcRepeat = false;
                    }
                    //Bottom left to Top Right
                    else if (GameBoard.matrix[2, 0] == "O" && GameBoard.matrix[1,1] == "O" && GameBoard.matrix[0, 2] != "X" && GameBoard.matrix[0, 2] != "O")
                    {
                        Waiting();
                        GameBoard.matrix[0,2] = "O";
                        pcRepeat = false;
                    }
                    else if (GameBoard.matrix[2, 0] == "O" && GameBoard.matrix[0,2] == "O" && GameBoard.matrix[1, 1] != "X" && GameBoard.matrix[1, 1] != "O")
                    {
                        Waiting();
                        GameBoard.matrix[1,1] = "O";
                        pcRepeat = false;
                    }
                    else if (GameBoard.matrix[1,1] == "O" && GameBoard.matrix[1,1] == "O" && GameBoard.matrix[2, 0] != "X" && GameBoard.matrix[2, 0] != "O")
                    {
                        Waiting();
                        GameBoard.matrix[2,0] = "O";
                        pcRepeat = false;
                    }
                    //Bottom vertical win
                    else if (GameBoard.matrix[2, 0] == "O" && GameBoard.matrix[2, 1] == "O" && GameBoard.matrix[2, 2] != "X" && GameBoard.matrix[2, 2] != "O")
                    {
                        Waiting();
                        GameBoard.matrix[2, 2] = "O";
                        pcRepeat = false;
                    }
                    else if (GameBoard.matrix[2, 1] == "O" && GameBoard.matrix[2, 2] == "O" && GameBoard.matrix[2, 0] != "X" && GameBoard.matrix[2, 0] != "O")
                    {
                        Waiting();
                        GameBoard.matrix[2, 0] = "O";
                        pcRepeat = false;
                    }
                    else if (GameBoard.matrix[2, 0] == "O" && GameBoard.matrix[2, 2] == "O" && GameBoard.matrix[2, 1] != "X" && GameBoard.matrix[2, 1] != "O")
                    {
                        Waiting();
                        GameBoard.matrix[2, 1] = "O";
                        pcRepeat = false;
                    }

                    // If non of the above, random place
                    else if (GameBoard.matrix[num1, num2] != "X" && GameBoard.matrix[num1, num2] != "O")
                    {
                        Waiting();
                        Console.WriteLine("The Computer has decided the next move.\n");
                        GameBoard.matrix[num1, num2] = "O";
                        pcRepeat = false;
                    }
                    else
                    {
                        
                        if(counter_ <= 3)
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
                            counter_++;
                        }
                        else
                        {                           
                            num1 = r.Next(0, 2);
                            num2 = r.Next(0, 2);
                        }
                        
                    }
                    
                    
                } while (pcRepeat == true && WinLogic.stop == false);
                counter_ = 3;
                Program.check++;
                GameBoard.Board();
                WinLogic.PCWINCheck();

            }

        }
        static public void aiPlus()
        {
            Random r2 = new Random();
            int rng;
            if (GameBoard.matrix[0, 0] == "X")
            {
                rng = r2.Next(1, 2);
                if (rng == 1 && (GameBoard.matrix[0, 1] != "O" && GameBoard.matrix[0, 1] != "X") || GameBoard.matrix[1, 1] != "O" && GameBoard.matrix[1, 1] != "X")
                {
                    GameBoard.matrix[0, 1] = "O";
                }
                else if (rng == 2 && (GameBoard.matrix[1, 1] != "O" && GameBoard.matrix[1, 1] != "X" || GameBoard.matrix[1, 1] != "O" && GameBoard.matrix[1, 1] 
                    != "X" && GameBoard.matrix[0, 1] != "O" && GameBoard.matrix[0, 1] != "X"))
                {
                    GameBoard.matrix[1, 1] = "O";
                }
            }//end if
        }//end aiPlus()

        static public void Waiting()
        {
            Console.Write("Computer is thinking");
            Thread.Sleep(150);
            Console.Write(".");
            Thread.Sleep(150);
            Console.Write(".");
            Thread.Sleep(150);
            Console.Write(".");
            Thread.Sleep(150);
            Console.WriteLine("\n");
        }
    }

}
