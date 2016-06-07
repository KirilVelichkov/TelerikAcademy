using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ParseURL
{
    static void Main()
    {
        string text = Console.ReadLine();

        string[] result1 = text.Split(new string[] { "://" }, StringSplitOptions.None);
        Console.WriteLine("[protocol] = {0}", result1[0]);
        string[] result2 = result1[1].Split('/');
        Console.WriteLine("[server] = {0}", result2[0]);
        string[] result3 = text.Split(new string[] { result2[0] }, StringSplitOptions.None);
        Console.WriteLine("[resource] = {0}", result2[1]);
    }
}