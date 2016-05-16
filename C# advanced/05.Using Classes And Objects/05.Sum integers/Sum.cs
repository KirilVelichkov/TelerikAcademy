using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sum_integers
{
    class Sum
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            SumArr(arr);
        }
        static void SumArr(int[] arr)
        {
            Console.WriteLine(arr.Sum());
        }
    }
}
