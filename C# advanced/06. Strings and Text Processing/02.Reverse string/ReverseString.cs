using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Reverse_string
{
    class ReverseString
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(input.Reverse().ToArray());
        }
    }
}
