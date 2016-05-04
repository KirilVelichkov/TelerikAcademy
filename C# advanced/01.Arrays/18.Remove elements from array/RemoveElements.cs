using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Remove_elements_from_array
{
    class RemoveElements
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] arr = new int[N];
            int[] dp = new int[N];

            for (int i = 0; i < N; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int maxSizeOfSubseq = 0;
            for (int i = 0; i < N; i++)
            {
                dp[i] = 1;
                maxSizeOfSubseq = 0;
                for (int j = 0; j <= i - 1; j++)
                {
                    if (arr[j] <= arr[i] && dp[j] >= maxSizeOfSubseq)
                    {
                        maxSizeOfSubseq = dp[j];
                    }
                }
                dp[i] = dp[i] + maxSizeOfSubseq;
            }
          

            //Now find the Max Size Of Subsequence amongst all computes subsequence lengths
            maxSizeOfSubseq = 0;
            for (int count = 0; count < dp.Length; ++count)
            {
                if (dp[count] > maxSizeOfSubseq)
                {
                    maxSizeOfSubseq = dp[count];
                }
            }

            Console.WriteLine(N - maxSizeOfSubseq);

            //int maxNumber = arr.Max();
            //int maxNumberIndex = arr.ToList().IndexOf(maxNumber);

            //for (int i = 1; i < N; i++)
            //{
            //    for (int j = 0; j < N; j++)
            //    {
            //        if(arr[i] > arr[j])
            //        {
            //            break;
            //        }
            //    }
            //}

            //foreach (int n in arr)
            //{
            //    Console.WriteLine(n);
            //}

            //arr = arr.Where(val => val != 0).ToArray();
            //Console.WriteLine(arr.Length);

        }
    }
}
