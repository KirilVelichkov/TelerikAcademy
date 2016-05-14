using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Integer_Calculations
{
    class IntCalculations
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(Minimum(arr));
            Console.WriteLine(Maximum(arr));
            Console.WriteLine("{0:F2}",Average(arr));
            Console.WriteLine(Sum(arr));
            Console.WriteLine(Product(arr));
        }

        static int Minimum(int[] arr)
        {
            return arr.Min();
        }
        static int Maximum(int[] arr)
        {
            return arr.Max();
        }
        static decimal Average(int[] arr)
        {
            decimal result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i];
            }
            return result / arr.Length;
        }
        static int Sum(int[] arr)
        {
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i];
            }
            return result;
        }
        static decimal Product(int[] arr)
        {
            decimal result = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                result *= arr[i];
            }
            return result;
        }
    }
}
