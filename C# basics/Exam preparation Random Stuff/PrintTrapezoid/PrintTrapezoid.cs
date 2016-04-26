using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Cartesian_Coordinate_System
{
    class Cartesian
    {
        static void myPrinter(int col, int row, string symbol)
        {
            Console.SetCursorPosition(col, row);
            Console.Write(symbol);
        }
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int height = N + 1;
            int bottom = 2 * N;
            int col = bottom - N;
            int row = 0;
            string direction = "right";
            bool stop = false;
            Console.Clear();
            //print dots
            for (int i = 1; i <= bottom * height; i++)
            {
                Console.Write('.');
                if (i % bottom == 0)
                {
                    Console.WriteLine();
                }
            }
            //print trapezoid
            for (int i = 1; i <= N + (2 * height) + bottom; i++)
            {
                if (direction == "right")
                {
                    col++;
                }
                if (direction == "down")
                {
                    row++;
                }
                if (direction == "left")
                {
                    col--;
                }
                if (direction == "up")
                {
                    col++;
                    row--;
                }

                if (direction == "right" && col == bottom)
                {
                    direction = "down";
                }

                if (direction == "down" && row == height)
                {
                    direction = "left";
                }
                if (direction == "left" && col == 0)
                {
                    direction = "up";
                }
                if (direction == "up" && col > N)
                {
                    stop = true;
                }
                if (!stop)
                {
                    myPrinter(col, row, "*");

                }
            }
            Console.SetCursorPosition(bottom + 1, height + 1);
        }
    }
}
