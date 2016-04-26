using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireInTheMatrix
{
    class FireMatrix
    {
        static void myPrinter(int col, int row, string symbol)
        {
            Console.SetCursorPosition(col, row);
            Console.Write(symbol);
        }
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int col = (N / 2) / 2;
            int row = N / 2 + ((N / 2) / 2);
            int colT = 0;
            int rowT = N / 2 + ((N / 2) / 2) + 2;
            int height = N + 1 + ((N / 2) / 2);
            string fireDirection = "up";
            bool stopFire = false;
            Console.Clear();

            //print board
            for (int i = 1; i <= N * height; i++)
            {
                Console.Write('.');
                if (i % N == 0)
                {
                    Console.WriteLine();
                }
            }
            for (int i = 1; i <= (N / 2) * 3; i++)
            {
                //print fire
                if (fireDirection == "up" && col == 0)
                {
                    fireDirection = "right";
                    col = -1;
                }
                if (fireDirection == "right" && row == 0)
                {
                    fireDirection = "down";
                    row = -1;
                }
                if (fireDirection == "down" && col == N - 1)
                {
                    fireDirection = "left";
                    col = N;
                }
                if (fireDirection == "left" && col == N / 2 + ((N / 2) / 2))
                {
                    stopFire = true;
                }
                //---
                if (fireDirection == "up")
                {
                    col--;
                    row--;
                }
                if (fireDirection == "right")
                {
                    col++;
                    row--;
                }
                if (fireDirection == "down")
                {
                    col++;
                    row++;
                }
                if (fireDirection == "left")
                {
                    col--;
                    row++;
                }
                if (!stopFire)
                {
                    myPrinter(col, row, "#");
                }
                //print line
                if (i <= N)
                {
                    myPrinter(i - 1, rowT - 2, "-");
                }
            }
            int counter = (N / 2) + 1;
            for (int i = 1; i <= N / 2; i++)
            {
                counter--;
                for (int j = 1; j <= counter; j++)
                {
                    myPrinter(j + i - 2, rowT + i - 2, @"\");
                    myPrinter(j + (N / 2) - 1, rowT + i - 2, @"/");
                }
            }
            Console.SetCursorPosition(0, height + 1);
            
        }
    }
}
