using TicTacToeEasy;

namespace LogicClasses
{

    public class WinLogic
    {
        static public bool gameWin = false;
        static public bool stop = false;
        static public bool playerWins = false;

        // Checks if player wins
        static public void PlayerWinCheck()
        {

            // Top Row
            if (GameBoard.matrix[0, 0] == "X" && GameBoard.matrix[0, 1] == "X" && GameBoard.matrix[0, 2] == "X")
            {
                Console.WriteLine("Player Wins! (1,2,3)\n");
                playerWins = true;
                gameWin = true;
            }
            // Top Left to Bottom Right
            else if (GameBoard.matrix[0, 0] == "X" && GameBoard.matrix[1, 1] == "X" && GameBoard.matrix[2, 2] == "X")
            {
                Console.WriteLine("Player Wins! (1,5,9)\n");
                playerWins = true;
                gameWin = true;
            }
            // Left Row Vertical
            else if (GameBoard.matrix[0, 0] == "X" && GameBoard.matrix[1, 0] == "X" && GameBoard.matrix[2, 0] == "X")
            {
                Console.WriteLine("Player Wins! (1,4,7)\n");
                playerWins = true;
                gameWin = true;
            }
            // Middle Vertical
            else if (GameBoard.matrix[0, 1] == "X" && GameBoard.matrix[1, 1] == "X" && GameBoard.matrix[2, 1] == "X")
            {
                Console.WriteLine("Player Wins! (2,5,8)\n");
                playerWins = true;
                gameWin = true;
            }
            // Middle Horizontal
            else if (GameBoard.matrix[1, 0] == "X" && GameBoard.matrix[1, 1] == "X" && GameBoard.matrix[1, 2] == "X")
            {
                Console.WriteLine("Player Wins! (4,5,6)\n");
                playerWins = true;
                gameWin = true;
            }
            // Right Vertical
            else if (GameBoard.matrix[0, 2] == "X" && GameBoard.matrix[1, 2] == "X" && GameBoard.matrix[2, 2] == "X")
            {
                Console.WriteLine("Player Wins! (3,6,9)\n");
                playerWins = true;
                gameWin = true;
            }
            // Top Right to Bottom Left
            else if (GameBoard.matrix[0, 2] == "X" && GameBoard.matrix[1, 1] == "X" && GameBoard.matrix[2, 0] == "X")
            {
                Console.WriteLine("Player Wins! (3,5,7)\n");
                playerWins = true;
                gameWin = true;
            }
            // Bottom Horizontal
            else if (GameBoard.matrix[2, 0] == "X" && GameBoard.matrix[2, 1] == "X" && GameBoard.matrix[2, 2] == "X")
            {
                Console.WriteLine("Player Wins! (7,8,9)\n");
                playerWins = true;
                gameWin = true;
            }
            else
            {

            }
        }

        // Checks if PC wins
        static public void PCWINCheck()
        {
            // Top Row
            if (GameBoard.matrix[0, 0] == "O" && GameBoard.matrix[0, 1] == "O" && GameBoard.matrix[0, 2] == "O")
            {
                
                gameWin = true;
                Console.WriteLine("COMPUTER Wins! (1,2,3)\n");
            }
            // Top Left to Bottom Right
            else if (GameBoard.matrix[0, 0] == "O" && GameBoard.matrix[1, 1] == "O" && GameBoard.matrix[2, 2] == "O")
            {
                
                gameWin = true;
                Console.WriteLine("COMPUTER Wins! (1,5,9)\n");
            }
            // Left Row Vertical
            else if (GameBoard.matrix[0, 0] == "O" && GameBoard.matrix[1, 0] == "O" && GameBoard.matrix[2, 0] == "O")
            {
                
                gameWin = true;
                Console.WriteLine("COMPUTER Wins! (1,4,7)\n");
            }
            // Middle Vertical
            else if (GameBoard.matrix[0, 1] == "O" && GameBoard.matrix[1, 1] == "O" && GameBoard.matrix[2, 1] == "O")
            {
                
                gameWin = true;
                Console.WriteLine("COMPUTER Wins! (2,5,7)\n");
            }
            // Middle Horizontal
            else if (GameBoard.matrix[1, 0] == "O" && GameBoard.matrix[1, 1] == "O" && GameBoard.matrix[1, 2] == "O")
            {
                
                gameWin = true;
                Console.WriteLine("COMPUTER Wins! (4,5,6)\n");
            }
            // Right Vertical
            else if (GameBoard.matrix[0, 2] == "O" && GameBoard.matrix[1, 2] == "O" && GameBoard.matrix[2, 2] == "O")
            {
                
                gameWin = true;
                Console.WriteLine("COMPUTER Wins! (3,6,9)\n");
            }
            // Top Right to Bottom Left
            else if (GameBoard.matrix[0, 2] == "O" && GameBoard.matrix[1, 1] == "O" && GameBoard.matrix[2, 0] == "O")
            {
                
                gameWin = true;
                Console.WriteLine("COMPUTER Wins! (3,5,7)\n");
            }
            // Bottom Horizontal
            else if (GameBoard.matrix[2, 0] == "O" && GameBoard.matrix[2, 1] == "O" && GameBoard.matrix[2, 2] == "O")
            {
                
                gameWin = true;
                Console.WriteLine("COMPUTER Wins! (7,8,9)\n");
            }
            else
            {

            }
        }
        public static void Draw()
        {
            do
            {
                PlayerLogic.Player();
                if (gameWin == true)
                {
                    Console.WriteLine("\nThanks for playing! Press Enter to Quit.");
                    stop = true;
                    Console.ReadKey();
                }
                else if (Program.check >= 9 && AiLogic.aiDraw == false)
                {

                    Console.WriteLine("\nGame is a DRAW");
                    stop = true;
                    Console.ReadKey();

                }
            } while (stop == false);
        }
    }
}
