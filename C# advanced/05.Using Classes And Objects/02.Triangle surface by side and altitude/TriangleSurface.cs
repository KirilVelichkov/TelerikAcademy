using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Triangle_surface_by_side_and_altitude
{
    class TriangleSurface
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}",TriangleSurfaceBySideAndAltitude(a, h));
        }

        static double TriangleSurfaceBySideAndAltitude(double a, double h)
        {
            double surface = (a * h) / 2;
            return surface;
        }
    }
}
