using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Factorial
{
    class NFactorial
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(N));
        }
        static BigInteger Factorial(int n)
        {
            BigInteger result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
