using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Maximal_Sequence
{
    class MaximalSequence
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
            for (int i = 1; i < N; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    count++;
                }
                else
                {
                    if(count > max)
                    {
                        max = count;
                    }
                    count = 1;
                }
            }
            if(count > max)
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
