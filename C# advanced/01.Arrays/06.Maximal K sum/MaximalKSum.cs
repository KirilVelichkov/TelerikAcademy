using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Maximal_K_sum
{
    class MaximalKSum
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            int[] arr = new int[N];
            int result = 0;

            for (int i = 0; i < N; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < K; i++)
            {
                int maxValue = arr.Max();
                int maxIndex = arr.ToList().IndexOf(maxValue);
                result += arr[maxIndex];
                arr[maxIndex] = int.MinValue;
            }
            Console.WriteLine(result);
        }
    }
}
