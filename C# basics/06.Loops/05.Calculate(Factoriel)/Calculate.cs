using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Calculate_Factoriel_
{
    class Calculate
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double numerator = 1;
            double denominator = 0;
            double sum = 0;

            for (int i = 1; i <= N; i++)
            {
                numerator *= i;
                denominator = Math.Pow(x, i);
                sum += numerator / denominator;
            }
            Console.WriteLine("{0:F5}", (sum+1));
        }
    }
}
