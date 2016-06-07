using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Parse_Tags
{
    class ParseTags
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Console.WriteLine(BoldTags(input,"<upcase>","</upcase>"));
            

        }

        static string BoldTags(string input, string openTag, string closeTag)
        {
            string result = string.Empty;
            string[] splitOpenTag = input.Split(new string[] { openTag }, StringSplitOptions.None);
            string[] splitCloseTag = new string[splitOpenTag.Length];

            for (int i = 1; i < splitOpenTag.Length; i++)
            {
                splitCloseTag = splitOpenTag[i].Split(new string[] { closeTag }, StringSplitOptions.None);
                result += splitCloseTag[0].ToUpper() + splitCloseTag[1];

            }
            return splitOpenTag[0] + result;
        }
    }
}
