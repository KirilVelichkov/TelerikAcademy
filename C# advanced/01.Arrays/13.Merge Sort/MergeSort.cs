using System;
using System.Linq;


class MergeSort
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] arr = new int[N];

        int[] arrResult = new int[N];
        for (int i = 0; i < N; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int[] arrClone = (int[])arr.Clone();

        for (int i = 0; i < N; i++)
        {
            int maxValue = arr.Max();
            int maxIndex = arr.ToList().IndexOf(maxValue);
            arrResult[i] = arr[maxIndex];
            arr[maxIndex] = int.MinValue;
        }
        Array.Reverse(arrResult);
        foreach (int n in arrResult)
        {
            Console.WriteLine(n);
        }
    }
}

