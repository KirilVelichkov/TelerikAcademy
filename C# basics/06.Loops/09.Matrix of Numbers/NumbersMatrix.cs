using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Matrix_of_Numbers
{
    class NumbersMatrix
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int count = 0;
            //Nested Loops solution
            //for (int i = 1; i <= N; i++)
            //{
            //    count++;
            //    for (int j = 0; j < N; j++)
            //    {
            //        Console.Write(j + i);
            //        if (j == N - 1)
            //        {
            //            Console.WriteLine();
            //        }
            //    }
            //}
            //Challenge solution without nested loops
            for (int i = 1; i <= N * N; i++)
            {
                Console.Write("{0} ", i + count);
                if (i % N == 0)
                {
                    count = count - (N - 1);
                    Console.WriteLine();
                }
            }
        }
    }
}
