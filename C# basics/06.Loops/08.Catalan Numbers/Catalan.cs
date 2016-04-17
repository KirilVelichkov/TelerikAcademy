using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _08.Catalan_Numbers
{
    class Catalan
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            BigInteger numenator = 1;
            BigInteger denominator = 0;
            BigInteger result = 0;
            BigInteger factoriel_2n = 1;
            BigInteger factoriel_n = 1;
            BigInteger factoriel_1plusN = 1;

            for (int i = 1; i <= 2*N; i++)
            {
                factoriel_2n *= i;
                if(i <= N + 1)
                {
                    factoriel_1plusN *= i;
                }
                if(i<= N)
                {
                    factoriel_n *= i;
                }
            }
            numenator = factoriel_2n;
            denominator = factoriel_1plusN * factoriel_n;
            result = numenator / denominator;
            Console.WriteLine(result);
        }
    }
}
