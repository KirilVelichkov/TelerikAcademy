using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.BinaryShort
{
    class BinShort
    {
        static void Main()
        {
            short n = short.Parse(Console.ReadLine());
            Console.WriteLine(BinaryShort(n));
        }
        static string BinaryShort(short n)
        {
            string str = Convert.ToString(n, 2);
            str = str.Substring(Math.Max(str.Length - 16, 0)).PadLeft(16, '0');
            return str;
        }

    }
}
