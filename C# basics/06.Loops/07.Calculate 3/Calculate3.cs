using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _07.Calculate3
{
    class Calculate3
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            BigInteger factorielN = 1;
            BigInteger factorielK = 1;
            BigInteger factorielN_K = 1;;
            BigInteger result = 0;

            for (int i = (K + 1); i <= N; i++)
            {
                factorielN *= (ulong)i;
                factorielN_K *= (ulong)i - (ulong)K;
            }
            result = factorielN / factorielN_K;
            Console.WriteLine(factorielN / factorielN_K);
        }
    }
}