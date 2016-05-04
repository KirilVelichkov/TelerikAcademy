using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Allocate_Array
{
    class AllocateArray
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] arrN = new int[N];
            for (int i = 0; i < N; i++)
            {
                arrN[i] = i;
                Console.WriteLine(arrN[i] * 5);
            }

        }
    }
}
