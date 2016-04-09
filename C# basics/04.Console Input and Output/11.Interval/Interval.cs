using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Interval
{
    class Interval
    {
        static void Main()
        {
            short N = short.Parse(Console.ReadLine());
            short M = short.Parse(Console.ReadLine());
            int count = 0;
            for (int i = N+1; i < M; i++)
            {
                if (i % 5 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
