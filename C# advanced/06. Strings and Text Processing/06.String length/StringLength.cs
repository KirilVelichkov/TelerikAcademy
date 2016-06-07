using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.String_length
{
    class StringLength
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(CheckStringLengthAndFill(input));
        }
        static StringBuilder CheckStringLengthAndFill(string input)
        {
            StringBuilder result = new StringBuilder();
            input = input.Replace(@"\", string.Empty);
            int inputLenght = input.Length;
            for (int i = 0; i < 20; i++)
            {
                if(i < inputLenght)
                {
                    result.Append(input[i]);
                }
                else
                {
                    result.Append('*');
                }
            }

            return result;
        }
    }
}
