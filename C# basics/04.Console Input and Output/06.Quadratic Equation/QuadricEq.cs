using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Quadratic_Equation
{
    class QuadricEq
    {
        static void Main()
        {

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double D = (b * b) - (4 * a * c);
            if (D < 0)
            {
                Console.WriteLine("no real roots");
            }
            if (D > 0)
            {
                double x1 = (-b - Math.Sqrt(D)) / (2 * a);
                double x2 = (-b + Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("{0:F2}", x1);
                Console.WriteLine("{0:F2}", x2);
            }
            if (D == 0)
            {
                double x1x2 = -(b / (2 * a));
                Console.WriteLine("{0:F2}", x1x2);
            }

        }
    }
}
