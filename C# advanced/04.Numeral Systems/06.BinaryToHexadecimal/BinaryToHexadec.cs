using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.BinaryToHexadecimal
{
    class BinaryToHexadec
    {
        static void Main()
        {
            string binary = Console.ReadLine();
            Console.WriteLine(BinaryToHexadecimal(binary));
        }
        static string BinaryToHexadecimal(string binary)
        {
            long binToDec = BinaryToDecimal(binary);
            return DecimalToHexadecimal(binToDec);
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
        static string DecimalToHexadecimal(long number)
        {
            string calc = "";
            string code = "";

            while (number > 0)
            {
                switch (number % 16)
                {
                    case 0: code = "0"; break;
                    case 1: code = "1"; break;
                    case 2: code = "2"; break;
                    case 3: code = "3"; break;
                    case 4: code = "4"; break;
                    case 5: code = "5"; break;
                    case 6: code = "6"; break;
                    case 7: code = "7"; break;
                    case 8: code = "8"; break;
                    case 9: code = "9"; break;
                    case 10: code = "A"; break;
                    case 11: code = "B"; break;
                    case 12: code = "C"; break;
                    case 13: code = "D"; break;
                    case 14: code = "E"; break;
                    case 15: code = "F"; break;
                }
                calc += code;
                number /= 16;
            }
            string result = new string(calc.Reverse().ToArray());
            return result;
        }
    }
}
