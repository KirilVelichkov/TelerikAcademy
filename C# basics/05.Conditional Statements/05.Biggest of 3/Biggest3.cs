﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Biggest_of_3
{
    class Biggest3
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if(a > b && a > c)
            {
                Console.WriteLine(a);
            }
           else if(b > a && b > c)
            {
                Console.WriteLine(b);
            }
            else if(c > a && c > b)
            {
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine(a);
            }
        }
    }
}
