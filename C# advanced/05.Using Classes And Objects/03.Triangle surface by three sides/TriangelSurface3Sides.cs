using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Triangle_surface_by_three_sides
{
    class TriangelSurface3Sides
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}",TriangleSurfaceByThreeSides(a, b, c));
        }
        static double TriangleSurfaceByThreeSides(double a, double b, double c)
        {
            double S = (a + b + c) / 2;
            double Area = Math.Sqrt(S * (S - a) * (S - b) * (S - c));
            return Area;
        }
    }
}
