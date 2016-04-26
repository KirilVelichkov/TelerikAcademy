using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AngryGPS
{
    class AngryGPS
    {
        static void Main()
        {

            //long n = long.Parse(Console.ReadLine());
            //if (n < 0)
            //{
            //    n *= -1;
            //}
            //int sumEven = 0;
            //int sumOdd = 0;
            //while (n != 0)
            //{
            //    int digit = (int)(n % 10);
            //    n /= 10;
            //    if (digit % 2 == 0)
            //    {
            //        sumEven += digit;
            //    }
            //    else
            //    {
            //        sumOdd += digit;
            //    }
            //}
            //if (sumEven == sumOdd)
            //{
            //    Console.WriteLine("straight {0}", sumEven);
            //}
            //else if (sumOdd > sumEven)
            //{
            //    Console.WriteLine("left {0}", sumOdd);
            //}
            //else
            //{
            //    Console.WriteLine("right {0}", sumEven);
            //}
            long number = long.Parse(Console.ReadLine());
            int sumOdd = 0;
            int sumEven = 0;

            if (number < 0)
            {
                number *= -1;
            }

            while (number > 0)
            {
               int positions = (int)(number % 10);
                    number /= 10;
                if (positions % 2 == 0)
                {
                    sumEven += positions;
                }
                else
                {
                    sumOdd += positions;
                }

            }
            if (sumEven > sumOdd)
            {
                Console.WriteLine("right {0}", sumEven);
            }
            else if (sumEven < sumOdd)
            {
                Console.WriteLine("left {0}", sumOdd);
            }
            else if (sumEven == sumOdd)
            {
                Console.WriteLine("straight {0}", sumOdd);
            }
        }
    }
}
