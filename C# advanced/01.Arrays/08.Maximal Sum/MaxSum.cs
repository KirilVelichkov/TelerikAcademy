using System;

public class Maximalsum
{
    public static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] arr = new int[N];

        for (int i = 0; i < N; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int maxSum = int.MinValue;
        int currentSum = 0;
        int tmpStart = 0;
        int end = N;
        int start = 0;

        for (int j = 0; j != N; ++j)
        {
            currentSum += arr[j];
            end = j;

            // if the sum is equal, choose the one with more elements
            if (currentSum > maxSum || (currentSum == maxSum && (end - start) < (j - tmpStart)))
            {
                maxSum = currentSum;
                start = tmpStart;
                end = j;
            }

            if (currentSum < 0)
            {
                currentSum = 0;
                tmpStart = j + 1;
            }
        }

        ////for (int i = 0; i < length - 1; i++)
        ////{
        ////    for (int j = i; j < length; j++)
        ////    {
        ////        currentSum += arr[j];
        ////        maxSum = Math.Max(maxSum, currentSum);
        ////    }
        ////    currentSum = 0;
        ////}
        ////  Console.WriteLine(maxSum);
        Console.WriteLine(maxSum);
    }
}