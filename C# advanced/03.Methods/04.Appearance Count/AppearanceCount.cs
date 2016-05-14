using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Appearance_Count
{
    class AppearanceCount
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] arrN = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int X = int.Parse(Console.ReadLine());

            Console.WriteLine(CountNumberInArray(X, arrN));
        }
        static int CountNumberInArray(int x, int[] arrN)
        {
            int count = 0;
            foreach (int n in arrN)
            {
                if(n == x)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
