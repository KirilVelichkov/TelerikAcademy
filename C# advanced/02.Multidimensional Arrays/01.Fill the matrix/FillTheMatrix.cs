using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Print(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (col < matrix.GetLength(1) - 1)
                {
                    Console.Write("{0} ", matrix[row, col]);
                }
                else
                {
                    Console.Write("{0}", matrix[row, col]);
                }
            }
            Console.WriteLine();
        }
    }
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        char C = char.Parse(Console.ReadLine());
        int[,] matrix = new int[N, N]; ///row , col
        string direction = string.Empty;
        int col = 0;
        int row = -1;
        #region case A
        if (C == 'a')
        {
            for (int trow = 0; trow < N; trow++)
            {
                for (int tcol = 0; tcol < N; tcol++)
                {
                    matrix[trow, tcol] = (tcol * N) + 1 + trow;
                }
            }
        }
        #endregion
        #region case B
        if (C == 'b')
        {
            direction = "down";

            for (int i = 0; i < N * N; i++)
            {

                if (direction == "down")
                {
                    row++;
                    if (row == N)
                    {
                        col = col + 1;
                        direction = "up";
                    }
                }
                if (direction == "up")
                {
                    row--;
                    if (row == 0)
                    {
                        matrix[row, col] = i + 1;
                        row = -1;
                        col = col + 1;
                        direction = "down";
                    }
                }
                if (row > -1)
                {
                    matrix[row, col] = i + 1;
                }
            }
        }
        #endregion
        #region case C
        if (C == 'c')
        {
            int startMiddle = 1;
            for (int i = 1; i < N; i++)
            {
                startMiddle += i;
            }
            int tempCol = 0;
            int tempRow = 0;
            col = 0;
            row = 0;
            //middle
            for (int i = startMiddle; i <= startMiddle + (N-1); i++)
            {
                matrix[tempRow, tempCol] = i;
                tempCol++;
                tempRow++;
            }
            col = tempCol - 2;
            row = tempRow - 1;
            int countCol = 1;
            //first half
            for (int i = startMiddle - 1; i >= 1; i--)
            {
                matrix[row, col] = i;
                if (col == 0)
                {
                    countCol++;
                    col = tempCol - countCol;
                    row = N;
                }
                col--;
                row--;
            }
            tempCol = 1;
            countCol = 0;
            col = 1;
            row = 0;
            //second half
            for (int i = startMiddle + N ; i <= N*N; i++)
            {
                matrix[row, col] = i;
                if (col == N-1)
                {
                    countCol++;
                    col = tempCol + countCol-1;
                    row = -1;
                }
                col++;
                row++;
            }
        }
        #endregion
        #region case D
        if (C == 'd')
        {
            direction = "down";
            col = 0;
            row = 0;
            for (int i = 0; i < N * N; i++)
            {
                if (direction == "right" && (col >= N || matrix[row, col] != 0))
                {
                    col--;
                    row--;
                    direction = "up";
                }
                if (direction == "down" && (row >= N || matrix[row, col] != 0))
                {
                    row--;
                    col++;
                    direction = "right";
                }
                if (direction == "left" && (col < 0 || matrix[row, col] != 0))
                {
                    col++;
                    row++;
                    direction = "down";
                }
                if (direction == "up" && (row < 0 || matrix[row, col] != 0))
                {
                    col--;
                    row++;
                    direction = "left";
                }
                matrix[row, col] = i + 1;
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
        }
        #endregion
       Print(matrix);
    }
}

