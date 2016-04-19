using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Int_Double_and_String
{
    class IntDoubleString
    {
        static void Main()
        {
            string type = Console.ReadLine();


            switch (type)
            {
                case "integer":
                    int value1 = int.Parse(Console.ReadLine());
                    Console.WriteLine(++value1);
                    break;
                case "real":
                    double value2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:F2}", ++value2);
                    break;
                case "text":
                    string value3 = Console.ReadLine();
                    Console.WriteLine("{0}*",value3);
                    break;
                default:
                    break;
            }
        }
    }
}
