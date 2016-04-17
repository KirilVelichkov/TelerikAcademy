using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MMSA_of_N_Numbers
{
    class MMSA
    {
        static void Main()

        {
            int N = int.Parse(Console.ReadLine());
            double[] MMSA = new double[N];
            double min = 10000;
            double max = -10000;
            double sum = 0;
            double avg = 0;

            for (int i = 0; i < N; i++)
            {
                MMSA[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < N; i++)
            {
                if (MMSA[i] >= max)
                {
                    max = MMSA[i];
                }
                if (MMSA[i] <= min)
                {
                    min = MMSA[i];
                }
                sum += MMSA[i];
            }
               
            avg = sum / N;
            Console.WriteLine("min={0:F2}", min);
            Console.WriteLine("max={0:F2}", max);
            Console.WriteLine("sum={0:F2}", sum);
            Console.WriteLine("avg={0:F2}", avg);
        }
    }
}
