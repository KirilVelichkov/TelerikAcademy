using MyExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods_Delegates_Lambda_LINKQ.Tests
{
    public static class IEnumerableTest
    {
        public static void Test()
        {
            IEnumerable<string> str = new[] { "Testing", "some", "string" };
            List<long> intiger = new List<long>{ 2000000000000000000, 2000000000000000000, 2000000000000000000, 2000000000000000000, 2000000000000000000 };
            IEnumerable<double> doubles = new[] { 1.2, 3.5, 5.5, 0.1, 10, 2 };
            Console.WriteLine("--- Testing IEnumerable Extensions ---");
            Console.WriteLine("--- String Test ---");
            Console.WriteLine("Testing some string: Min = : {0}", str.MyMin());
            Console.WriteLine("Testing some string: Max = : {0}",str.MyMax());
            Console.WriteLine("Testing some string: Product = : {0}",str.MyProduct());
            Console.WriteLine("Testing some string: Sum = : {0}",str.MySum());
            Console.WriteLine("Testing some string: Average = : {0}",str.MyAverage());

            Console.WriteLine("--- Int Test ---");
            Console.WriteLine("1, 2, 3, 6, 10, 20, 15: Min = : {0}", intiger.MyMin());
            Console.WriteLine("1, 2, 3, 6, 10, 20, 15: Max = : {0}", intiger.MyMax());
            Console.WriteLine("1, 2, 3, 6, 10, 20, 15: Product = : {0}", intiger.MyProduct());
            Console.WriteLine("1, 2, 3, 6, 10, 20, 15: Sum = : {0}", intiger.MySum());
            Console.WriteLine("1, 2, 3, 6, 10, 20, 15: Average = : {0}", intiger.MyAverage());

            Console.WriteLine("--- Double Test ---");
            Console.WriteLine("1.2, 3.5, 5.5, 0.1, 10, 2: Min = : {0}", doubles.MyMin());
            Console.WriteLine("1.2, 3.5, 5.5, 0.1, 10, 2: Max = : {0}", doubles.MyMax());
            Console.WriteLine("1.2, 3.5, 5.5, 0.1, 10, 2: Product = : {0}", doubles.MyProduct());
            Console.WriteLine("1.2, 3.5, 5.5, 0.1, 10, 2: Sum = : {0}", doubles.MySum());
            Console.WriteLine("1.2, 3.5, 5.5, 0.1, 10, 2: Average = : {0:0.0}", doubles.MyAverage());
        }
    }
}
