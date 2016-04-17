using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Decimal_to_Binary
{
    class DecimalToBinary
    {
        static void Main()
        {
            long input = long.Parse(Console.ReadLine());
            string outputBinary = "";
            
           
            while(input > 0)
            {
                long reminder = input % 2;
                outputBinary = outputBinary.Insert(0, reminder.ToString());
                input /= 2;
            }
            if(outputBinary == "")
            {
                Console.WriteLine(input);
            }
            else
            {
                Console.WriteLine(outputBinary);
            }
            
        }
    }
}
