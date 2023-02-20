using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeEasy
{
    public class GameBoard
    {
        static public string[,] matrix = { { "1", "2", "3" },
                             { "4", "5" ,"6" },
                             { "7", "8" ,"9" }
                           };

        static public void Board()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "   ");
                }
                Console.WriteLine("\n");
            }
        }
    }

    
}
