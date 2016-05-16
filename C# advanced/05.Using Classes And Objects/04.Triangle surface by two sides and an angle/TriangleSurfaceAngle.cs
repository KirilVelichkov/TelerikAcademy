using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Triangle_surface_by_two_sides_and_an_angle
{
    class TriangleSurfaceAngle
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double sin = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}", TriangleSurfaceByTwoSidesAndAngle(a,b, sin));
        }
        static double TriangleSurfaceByTwoSidesAndAngle(double a, double b, double sin)
        {
            double angle = Math.PI * sin / 180.0;
            double sinAngle = Math.Sin(angle);
            double area = (a * b * sinAngle) / 2;
            return area;
        }
    }
}
