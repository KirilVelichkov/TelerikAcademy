using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.English_Digit
{
    class EnglishDigit
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(DigitAsWord(n));
        }
        static string DigitAsWord(int n)
        {
            string stringN = n.ToString();
            char last = stringN[stringN.Length-1];

            string[] words = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            return words[last - '0'];
        }
    }
}
