using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01.Sum_of_3_Numbers
{
    static class SumOf3
    {

        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double sum = a + b + c;
            Console.Write(sum);
        }
    }
}
