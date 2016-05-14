﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.HexadecimalToDecimal
{
    class HexdecToDec
    {
        static void Main()
        {
            string hex = Console.ReadLine();
            Console.WriteLine(HexadecimalToDecimal(hex));
            
        }
        static long HexadecimalToDecimal(string hex)
        {
            long count = 1;
            int code = 0;
            long result = 0;
            foreach (char c in hex.Reverse().ToArray())
            {
                switch (c)
                {
                    case '0': code = 0; break;
                    case '1': code = 1; break;
                    case '2': code = 2; break;
                    case '3': code = 3; break;
                    case '4': code = 4; break;
                    case '5': code = 5; break;
                    case '6': code = 6; break;
                    case '7': code = 7; break;
                    case '8': code = 8; break;
                    case '9': code = 9; break;
                    case 'A': code = 10; break;
                    case 'B': code = 11; break;
                    case 'C': code = 12; break;
                    case 'D': code = 13; break;
                    case 'E': code = 14; break;
                    case 'F': code = 15; break;
                }
                result += code * count;
                count <<= 4;
            }
            return result;
        }
    }
}
