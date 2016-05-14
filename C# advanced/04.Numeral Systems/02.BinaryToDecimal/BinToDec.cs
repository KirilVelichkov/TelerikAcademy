using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BinaryToDecimal
{
    class BinToDec
    {
        static void Main()
        {
            string binary = Console.ReadLine();
            Console.WriteLine(BinaryToDecimal(binary));
        }
        static long BinaryToDecimal(string binary)
        {
            long count = 1;
            long result = 0;

            foreach (char c in binary.Reverse().ToArray())
            {
                if (c == '1')
                {
                    result += count;
                }
                count <<= 1;
            }
            return result;
        }
    }
}
