using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.LargetThanNeighbours
{
    class LargetThanNeighbours
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] N_Array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(CountLargetThanNeighbours(N_Array));
        }
         static int CountLargetThanNeighbours(int[] array)
        {
            int count = 0;
            for (int i = 1; i < array.Length - 1; i++)
            {

                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    count++;
                }
            }

            return count;
        }
    }
}
