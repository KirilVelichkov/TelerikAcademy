using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ReverseNumber
{
    class ReverseNumbers
    {
        static void Main()
        {
            string dec = Console.ReadLine();
            Console.WriteLine(ReverseDigits(dec));
        }
       

        static string ReverseDigits(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
