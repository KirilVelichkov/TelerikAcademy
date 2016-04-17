using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace _11.Binary_to_Decimal
{
    class BinaryToDecimal
    {
        static void Main()
        {

            string input = Console.ReadLine();
         
            int @decimal = 0;
            int number = 0;
            int inputLength = input.Length - 1;
            //48 = 0;
            //49 = 1;

            for (int i = 0; i <= inputLength; i++)
            {
                number = input[inputLength - i];
                if (number == 49) //1
                {
                    @decimal += (int)Math.Pow(2, i);
                }
            }
            Console.WriteLine(@decimal);
        }
    }
}
