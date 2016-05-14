using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Dec_To_Binary
{
    class DecToBin
    {
        static void Main()
        {
            long dec = long.Parse(Console.ReadLine());
            Console.WriteLine(DecToBinary(dec));
        }

        static string DecToBinary(long n)
        {
            string build = "";
            long dec = n;
            while(n > 0)
            {
                build += n % 2;
                n /= 2;
            }
            string result = new string(build.Reverse().ToArray());
            if(dec == 0)
            {
                return "0";
            }
            else
            {
                return result;
            }
        }
    }
}
