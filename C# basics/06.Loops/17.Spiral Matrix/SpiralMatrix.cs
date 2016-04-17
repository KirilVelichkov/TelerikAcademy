using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Spiral_Matrix
{
    class SpiralMatrix
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[,] matrix = new int[N, N];
            int col = 0;
            int row = 0;
            string direction = "right"; //right , down, left, up...

            for (int i = 1; i <= N * N; i++)
            {
                if (direction == "right" && (col >= N || matrix[row, col] != 0))
                {
                    col--;
                    row++;
                    direction = "down";
                }
                if (direction == "down" && (row >= N || matrix[row, col] != 0))
                {
                    row--;
                    col--;
                    direction = "left";
                }
                if (direction == "left" && (col < 0 || matrix[row, col] != 0))
                {
                    col++;
                    row--;
                    direction = "up";
                }
                if (direction == "up" && (row < 0 || matrix[row, col] != 0))
                {
                    col++;
                    row++;
                    direction = "right";
                }
                matrix[row, col] = i;
                if (direction == "right")
                {
                    col++;
                }
                else if (direction == "down")
                {
                    row++;
                }
                else if (direction == "left")
                {
                    col--;
                }
                else if (direction == "up")
                {
                    row--;
                }
            }
            for (int r = 0; r < N; r++)
            {
                for (int c = 0; c < N; c++)
                {
                    Console.Write(matrix[r, c] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
