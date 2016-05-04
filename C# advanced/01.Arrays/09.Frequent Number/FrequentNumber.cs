using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Frequent_Number
{
    class FrequentNumber
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] arr = new int[N];
            int[] arrResult = new int[N];
            int count = 1;
            int count2 = 1;
            int max = 1;
            int number = 0;
            int nTimes = 0;
            int[] arrTimes = new int[N];

            for (int i = 0; i < N; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < N; i++)
            {
                int maxValue = arr.Max();
                int maxIndex = arr.ToList().IndexOf(maxValue);
                arrResult[i] = arr[maxIndex];
                arr[maxIndex] = int.MinValue;
            }

            Array.Reverse(arrResult);

            for (int i = 1; i < N; i++)
            {
                if (arrResult[i - 1] == arrResult[i])
                {
                    count++;
                }
                else
                {
                    if (count > max)
                    {
                        max = count;
                    }
                    count = 1;
                }
            }

            nTimes = Math.Max(count, max);

            for (int i = 1; i < N; i++)
            {
                if (arrResult[i - 1] == arrResult[i])
                {
                    count2++;
                }
                else
                {
                    count2 = 1;
                }
                if (count2 == nTimes)
                {
                    number = arrResult[i];
                    break;
                }
            }
            //4 (5 times)
            Console.WriteLine("{0} ({1} times)", number, nTimes);
           
        }
    }
}
