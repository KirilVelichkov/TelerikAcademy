using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _06.Calculate_again
{
    class CalculateAgain
    {
        static void Main()
        {
            BigInteger N = BigInteger.Parse(Console.ReadLine());
            BigInteger K = BigInteger.Parse(Console.ReadLine());
            BigInteger dominator = 1;
            BigInteger denominator = 1;
            for (int i = 1; i <= N; i++)
            {
                dominator *= i;
                if(i <= K)
                {
                    denominator *= i;
                }
            }
            Console.WriteLine(dominator / denominator);
        }
    }
}
