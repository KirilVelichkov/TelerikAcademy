using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BatGoikoTower
{
    class GoikoTower
    {
        static void PrintOnPosition(int col, int row, string symbol)
        {
            Console.SetCursorPosition(col, row);
            Console.Write(symbol);
        }
        static void Main()
        {

            byte N = byte.Parse(Console.ReadLine());
            int col = -1;
            int row = N;
            int counter = 0;
            int counterMultiplier = 1;
            int counterDash1 = 2;
            int counterDash2 = 0;
            string symbol = "/";
            string direction = "up-right";
            bool stopPrint = false;
            Console.Clear();
            //print border
            for (int i = 1; i <= N * (2 * N); i++)
            {
                Console.Write(".");
                if (i % (N * 2) == 0)
                {
                    Console.WriteLine();
                }

            }
            for (int i = 1; i < N * (2 * N); i++)
            {
                if (direction == "up-right")
                {
                    col++;
                    row--;
                }
                if (direction == "down-right")
                {
                    col++;
                    row++;
                }
                if (direction == "up-right" && row < 0)
                {
                    direction = "down-right";
                    symbol = @"\";
                    row++;
                }
                if (direction == "down-right" && col == 2 * N)
                {
                    stopPrint = true;
                }
                if (!stopPrint)
                {
                    PrintOnPosition(col, row, symbol);
                }
                //print dash
                if (i == counterDash1 && counterDash1 <= N)
                {
                    counterDash2++;
                    counterDash1 = i + counterDash2 + 1;
                    counter += 2 * counterMultiplier;
                    counterMultiplier++;
                    for (int j = 0; j < counter/2; j++)
                    {
                        PrintOnPosition(N+j, i-1, "-");
                        PrintOnPosition((N-1)-j, i-1, "-");
                    }
                }
            }
        }
    }
}
