using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Correct_brackets
{
    class CorrectBrackets
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Console.WriteLine(FindBrackets(input,"(",")"));
        }

        static string FindBrackets(string str,string compare1, string compare2)
        {
            int startLeft = -1;
            int startRight = -1;
            int countLeft = 0;
            int countRight = 0;
            string result = "Correct";
            int[] leftBracket = new int[str.Length];
            int[] rightBracket = new int[str.Length];
            //  012(
            //  01)
            while (true)
            {
                startLeft = str.IndexOf(compare1, startLeft + 1,str.Length - startLeft - 1);

                if (startLeft < 0) { break; }
                leftBracket[countLeft] = startLeft;
                countLeft++;
            }
            while (true)
            {
                startRight = str.IndexOf(compare2, startRight + 1, str.Length - startRight - 1);

                if (startRight < 0) { break; }
                rightBracket[countRight] = startRight;
                countRight++;
            }
            for (int i = 0; i < str.Length; i++)
            {
                if(leftBracket[i] > rightBracket[i])
                {
                    result = "Incorrect";
                    break;
                }
            }
            if(countLeft != countRight)
            {
                result = "Incorrect";
            }
            return result;
        }
    }
}
