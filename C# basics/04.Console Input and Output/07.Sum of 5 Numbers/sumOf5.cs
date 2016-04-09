using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sum_of_5_Numbers
{
    class SumOf5
    {
        static void Main()
        {
            int N = 0;
            int sum = 0;
            for (int i = 1; i <= 5; i++)
            {
                N = int.Parse(Console.ReadLine());
                sum += N;
            }
            Console.WriteLine(sum);
        }
    }
}
