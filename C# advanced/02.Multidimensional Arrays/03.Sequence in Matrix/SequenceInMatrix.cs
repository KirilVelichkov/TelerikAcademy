using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SequenceInMatrix
{


    static void Main()
    {

        int[] N_M = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[][] matrix = new int[N_M[0]][];
        int count = 1;
        int sum = 1;
        int diagonal = (N_M[0] + N_M[1]) - 1;


        for (int j = 0; j < N_M[0]; j++)
        {
            matrix[j] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        }

        #region Columns
        for (int col = 0; col < N_M[1]; col++)
        {
            for (int row = 0; row < N_M[0] - 1; row++)
            {
                if (matrix[row][col] == matrix[row + 1][col])
                {
                    count++;
                }
                if (count > sum)
                {
                    sum = count;
                }
            }
            count = 1;
        }
        #endregion
        #region Rows
        for (int row = 0; row < N_M[0]; row++)
        {
            for (int col = 0; col < N_M[1] - 1; col++)
            {
                if (matrix[row][col] == matrix[row][col + 1])
                {
                    count++;
                }
                if (count > sum)
                {
                    sum = count;
                }
            }
            count = 1;
        }
        #endregion
        #region Diagonals
        /*
        1 2 3 4 5 6 7
        1 2 3 4 5 6 7
        1 2 3 4 5 6 7

        1 2
        1 2
        1 2
        1 2
      
    */
        //right diagonal
        int a = N_M[0];
        int b = N_M[1];

        int start_a = 0;
        int stop_a = a + b - 1;
        int start_b = 0;
        int stop_b = 1;

        int dRow = 0;
        int dCol = 0;

        for (int i = start_a; i < stop_a - 1; i++)
        {
            for (int j = start_b; j < stop_b - 1; j++)
            {

                //Console.Write("{0} {1} ", dRow - j, j + dCol);
                if (matrix[dRow - j][j + dCol] == matrix[dRow - j - 1][j + dCol + 1])
                {
                    count++;
                }
                if (count > sum)
                {
                    sum = count;
                }
                //Console.Write("{0} {1} ", dRow - j, j + dCol);
            }
            count = 1;
            stop_b++;
            dRow++;
            if (i >= a - 1)
            {
                dRow = a - 1;
                dCol++;
                stop_b--;
            }
            if (i >= b - 1)
            {
                stop_b--;
            }
        }
        //left diagonal
        #endregion
        start_a = 0;
        stop_a = a + b - 1;
        start_b = 0;
        stop_b = 1;

        dRow = 0;
        dCol = 0;
        for (int i = start_a; i < stop_a - 1; i++)
        {
            for (int j = start_b; j < stop_b - 1; j++)
            {
                if (matrix[dRow - j][b - 1 - j + dCol] == matrix[dRow - j - 1][b - 1 - j + dCol - 1])
                {
                    count++;
                }
                if (count > sum)
                {
                    sum = count;
                }
            }
            count = 1;
            stop_b++;
            dRow++;
            if (i >= a - 1)
            {
                dRow = a - 1;
                dCol--;
                stop_b--;
            }
            if (i >= b - 1)
            {
                stop_b--;
            }
        }
        if (count > sum)
        {
            Console.WriteLine(count);
        }
        else
        {
            Console.WriteLine(sum);
        }
    }
}
