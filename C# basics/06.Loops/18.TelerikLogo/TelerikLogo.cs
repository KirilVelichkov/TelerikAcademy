using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.TelerikLogo
{
    class TelerikLogo
    {
        static void Printer(int col, int row, string symbol)
        {
            Console.SetCursorPosition(col, row);
            Console.Write(symbol);
        }
        static void Main()
        {

            int x = int.Parse(Console.ReadLine());
            int y = x;
            int z = (x / 2) + 1;
            int stopper1 = (2 * x) + z - 2;
            int width = (x * 2) + (2 * z) - 3;
            int height = width;
            int col = z - 2;
            int row = 0;
            int colZ1 = 0;
            int rowZ1 = z;
            int colZ2 = stopper1-1;
            int rowZ2 = 1;
            bool stopPrinter = false;
            string direction = "down-right";

            //print dots
            for (int r = 1; r <= width; r++)
            {
                for (int j = 1; j <= height; j++)
                {
                    Console.Write(".");
                    if (j == height)
                    {
                        Console.WriteLine();
                    }
                }
            }
            //print Zs
            for (int i = 0; i < z; i++)
            {
                Printer(colZ1, rowZ1, "*");
                rowZ1--;
                colZ1++;
                Printer(colZ2, rowZ2, "*");
                rowZ2++;
                colZ2++;
            }
            
            //print logo
            for (int i = 1; i <= (width * 2) + 1; i++)
            {
                if (direction == "down-right")
                {
                    col++;
                    row++;
                }
                if (direction == "down-left")
                {
                    col--;
                    row++;
                }
                if (direction == "up-left")
                {
                    col--;
                    row--;
                }
                if (direction == "up-right")
                {
                    col++;
                    row--;
                }

                if (direction == "down-right" && col == stopper1)
                {
                    col--;
                    row--;
                    direction = "down-left";
                }
                else if (direction == "down-left" && row > height)
                {
                    col++;
                    row--;
                    direction = "up-left";
                }
                else if (direction == "up-left" && col < z)
                {
                    direction = "up-right";
                }
                else if (direction == "up-right" && col >= stopper1)
                {
                    stopPrinter = true;
                }
                if (!stopPrinter)
                {
                    Printer(col, row, "*");
                }
            }
            Console.SetCursorPosition(width + 1, height + 1);
        }
    }
}
