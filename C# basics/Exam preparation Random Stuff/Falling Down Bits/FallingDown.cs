using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Falling_Down_Bits
{
    class FallingDown
    {
        static void Main()
        {
            int a0 = int.Parse(Console.ReadLine());
            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int a3 = int.Parse(Console.ReadLine());
            int a4 = int.Parse(Console.ReadLine());
            int a5 = int.Parse(Console.ReadLine());
            int a6 = int.Parse(Console.ReadLine());
            int a7 = int.Parse(Console.ReadLine());

            int row0 = 0;
            int row1 = 0;
            int row2 = 0;
            int row3 = 0;
            int row4 = 0;
            int row5 = 0;
            int row6 = 0;
            int row7 = 0;

            for (int i = 0; i < 7; i++)
            {
                row0 = a0 & a1 & a2 & a3 & a4 & a5 & a6 & a7;
                row1 = (a1 & a2 & a3 & a4 & a5 & a6 & a7) | a0;
                row2 = (a2 & a3 & a4 & a5 & a6 & a7) | a1;
                row3 = (a3 & a4 & a5 & a6 & a7) | a2;
                row4 = (a4 & a5 & a6 & a7) | a3;
                row5 = (a5 & a6 & a7) | a4;
                row6 = (a6 & a7) | a5;
                row7 = a6 | a7;

                a0 = row0;
                a1 = row1;
                a2 = row2;
                a3 = row3;
                a4 = row4;
                a5 = row5;
                a6 = row6;
                a7 = row7;
            }
            Console.WriteLine(a0);
            Console.WriteLine(a1);
            Console.WriteLine(a2);
            Console.WriteLine(a3);
            Console.WriteLine(a4);
            Console.WriteLine(a5);
            Console.WriteLine(a6);
            Console.WriteLine(a7);
        }
    }
}
