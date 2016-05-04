using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Compare_Arrays
{
    class CompareArrays
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] arr1 = new int[N];
            int[] arr2 = new int[N];
            string equal = "Equal";

            for (int i = 0; i < N; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < N; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < N; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    equal = "Not equal";
                }

            }
            Console.WriteLine(equal);
        }
    }
}
