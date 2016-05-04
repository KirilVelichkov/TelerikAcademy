using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Compare_char_arrays
{
    class CharArrays
    {
        static void Main()
        {
            string arr1 = Console.ReadLine();
            string arr2 = Console.ReadLine();
            bool equal = true;
            string result = string.Empty;

            if(arr1.Length > arr2.Length)
            {
                equal = false;
                result = ">";
            }
            if (arr1.Length < arr2.Length)
            {
                equal = false;
                result = "<";
            }
            if (arr1.Length == arr2.Length)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] != arr2[i]) {
                        equal = false;
                        result = (arr1[i] < arr2[i]) ? "<" : ">";
                        break;
                    }
                }
            }
            Console.WriteLine(equal? "=" : result);
        }
    }
}
