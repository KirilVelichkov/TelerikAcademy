using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.GCD
{
    class GCD
    {
        static void Main()
        {
            int[] AB = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Array.Sort(AB);
            int a = AB[0];
            int b = AB[1];
            int result = 0;

            for (int i = 1; i <= b; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    result = i;
                }
            }
            Console.WriteLine(result);
        }
    }
}
