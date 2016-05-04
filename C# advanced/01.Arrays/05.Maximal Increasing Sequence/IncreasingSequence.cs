using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Maximal_Increasing_Sequence
{
    class IncreasingSequence
    {
        static void Main()
        {

            int N = int.Parse(Console.ReadLine());
            int[] arr = new int[N];
            int max = 1;
            int count = 1;
            for (int i = 0; i < N; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            //0, 1, 2, 3, 4
            //5, 2, 3, 4, 1
            for (int i = 1; i < N; i++)
            {
                if (arr[i] >= arr[i - 1] + 1)
                {
                    count++;
                }
                else
                {
                    if (count > max)
                    {
                        max = count;
                    }
                    count = 1;
                }
            }

            if (count > max)
            {
                Console.WriteLine(count);
            }
            else
            {
                Console.WriteLine(max);
            }

        }
    }
}
