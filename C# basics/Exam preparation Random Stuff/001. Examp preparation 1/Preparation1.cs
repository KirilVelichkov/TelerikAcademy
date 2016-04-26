using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;
namespace _001.Examp_preparation_1
{
    class Preparation1
    {
        public static int BitInPossition(int number, int bitOfpossition)
        {
            int c = (number & (1 << bitOfpossition)) >> bitOfpossition;
            return c;
        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] one = new string[5];
            one[0] = ".#.";
            one[1] = "##.";
            one[2] = ".#.";
            one[3] = ".#.";
            one[4] = "###";

            string[] zero = new string[5];
            zero[0] = "###";
            zero[1] = "#.#";
            zero[2] = "#.#";
            zero[3] = "#.#";
            zero[4] = "###";
            for (int j = 0; j <= 4; j++)
            {
                for (int i = 15; i >= 0; i--)
                {
                    int bit = BitInPossition(n, i);

                    if (bit == 1)
                    {
                        Console.Write(one[j]);
                    }
                    else
                    {
                        Console.Write(zero[j]);
                    }

                    if (i == 0)
                    {
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
            }
        }
    }
}
