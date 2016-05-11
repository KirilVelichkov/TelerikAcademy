using System;
using System.Linq;


class MaximalSum
{
    static void Main()
    {
        int[] N_M = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int sum = 0;
        int bestSum = int.MinValue;

        int[][] arrM = new int[N_M[0]][];

        for (int j = 0; j < N_M[0]; j++)
        {
            arrM[j] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        }

        for (int row = 0; row < N_M[0] - 2; row++)
        {
            for (int col = 0; col < N_M[1] - 2; col++)
            {
                sum = arrM[row][col] + arrM[row][col + 1] + arrM[row][col + 2] +
                      arrM[row + 1][col] + arrM[row + 1][col + 1] + arrM[row + 1][col + 2] +
                      arrM[row + 2][col] + arrM[row + 2][col + 1] + arrM[row + 2][col + 2];
                if (sum > bestSum)
                    bestSum = sum;
            }
        }
        Console.WriteLine(bestSum);
    }
}