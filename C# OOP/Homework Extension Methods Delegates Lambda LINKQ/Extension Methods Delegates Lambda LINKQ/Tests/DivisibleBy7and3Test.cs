using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods_Delegates_Lambda_LINKQ.Tests
{
    public static class DivisibleBy7and3Test
    {
        public static void Test()
        {
            Console.WriteLine("--- Testing Problem 6: Divisible by 7 and 3 ---");
            Console.WriteLine("The array is: 21, 35, 42, 55, 63");
            List<int> arr = new List<int> { 21, 35, 42, 55, 63 };
            List<int> divisbile = arr.FindAll(x => (x % 3) == 0 && (x % 7) == 0);
            Console.WriteLine();
            Console.WriteLine("---Numbers from array that are divisible by 7 and 3 ---");
            foreach (var item in divisbile)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
