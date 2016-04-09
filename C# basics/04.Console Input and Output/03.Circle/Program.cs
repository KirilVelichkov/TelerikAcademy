using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Circle
{
    class Program
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            double Area = Math.PI * Math.Pow(r, 2);
            double Perimeter = Math.PI * r * 2;

            Console.WriteLine("{0:F2} {1:F2}", Perimeter, Area);
        }
    }
}
