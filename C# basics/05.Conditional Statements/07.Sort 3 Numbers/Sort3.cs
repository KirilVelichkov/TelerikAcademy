using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sort_3_Numbers
{
    class Sort3
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            //Biggest
            if (a >= b && a >= c)
            {
                Console.Write("{0} ", a);
            }
            if (b >= a && b >= c)
            {
                Console.Write("{0} ", b);
            }
            if (c >= a && c >= b)
            {
                Console.Write("{0} ", c);
            }

            //Middle
            if (a < b && a > c)
            {
                Console.Write("{0} ", a);
            }
            if (b < a && b > c)
            {
                Console.Write("{0} ", b);
            }
            if (c < a && c > b)
            {
                Console.Write("{0} ", c);
            }

            if (a < c && a > b)
            {
                Console.Write("{0} ", a);
            }
            if (b < c && b > a)
            {
                Console.Write("{0} ", b);
            }
            if (c < b && c > a)
            {
                Console.Write("{0} ", c);
            }
            //Smallest
            if (a < b && a < c)
            {
                Console.Write("{0} ", a);
            }
            if (b < a && b < c)
            {
                Console.Write("{0} ", b);
            }
            if (c < a && c < b)
            {
                Console.Write("{0} ", c);
            }
        }
    }
}
