using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sub_string_in_Text
{
    class SubstringInText
    {
        static void Main()
        {
            string pattern = Console.ReadLine();
            string input = Console.ReadLine();
            Console.WriteLine(SubstringInTextCount(input,pattern));
        }

        static int SubstringInTextCount(string text, string pattern)
        {
            string[] result = text.ToLower().Split(new string[] { pattern.ToLower() }, StringSplitOptions.None);

            return result.Length-1;
        }
    }
}
