using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Sum_of_N_Numbers
{
    class SumOfN
    {
        static void Main()
        {
            double N = double.Parse(Console.ReadLine());
            double N2 = 0;
            double sum = 0;
            for (int i = 1; i <= N; i++)
            {
                N2 = double.Parse(Console.ReadLine());
                sum += N2;
            }
            Console.WriteLine(sum);
        }
    }
}
