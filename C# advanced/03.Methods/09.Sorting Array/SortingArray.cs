using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Sorting_Array
{
    class SortingArray
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] N_Array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arrResult = new int[N];
            for (int i = 0; i < N; i++)
            {
                int maxValue = N_Array.Max();
                int maxIndex = N_Array.ToList().IndexOf(maxValue);
                arrResult[i] = N_Array[maxIndex];
                N_Array[maxIndex] = int.MinValue;
            }
            Array.Reverse(arrResult);
            foreach (int n in arrResult)
            {
                Console.Write(n + " ");
            }
        }
    }
}
