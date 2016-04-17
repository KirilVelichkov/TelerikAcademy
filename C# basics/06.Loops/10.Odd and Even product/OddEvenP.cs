using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _10.Odd_and_Even_product
{
    class OddEvenP
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            string[] line2 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            BigInteger odd = 1;
            BigInteger even = 1;

            for (int i = 0; i < N; i++)
            {
                if (i % 2 == 0)
                {
                    even *= int.Parse(line2[i]);
                }
                else
                {
                    odd *= int.Parse(line2[i]);
                }
            }
            if (even == odd)
            {
                Console.WriteLine("yes {0}", even);
            }
            else
            {
                Console.WriteLine("no {0} {1}", even, odd);
            }
        }
    }
}
