

namespace ConsoleApplication1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            PrintName(17, weight: 18);
            int a = 10;
            int b = 20;
            
        }

        static void Sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        static void PrintName(int age, string name = "Unknown", int weight = 72)
        {
            Console.WriteLine("age {0}", age);
            Console.WriteLine("name {0}",name);
            Console.WriteLine("weight {0}",weight);
        }
        static int sum(int a, int b)
        {   

            return a + b;
        }

      
    }
}
