using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ApplesOrORanges
{
    class ApplesOrOranges
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int Apples = 0;
            int Oranges = 0;
            int number = 0;

            for (int i = 0; i < N.ToString().Length; i++)
            {
                number = N.ToString()[i];
                if (number % 2 == 0)
                {
                    Apples += number - 48;
                }
                else
                {
                    Oranges += number - 48;
                }
            }

            if (Apples > Oranges)
            {
                Console.WriteLine("apples {0}", Apples);
            }
            if (Oranges > Apples)
            {
                Console.WriteLine("oranges {0}", Oranges);
            }
            if (Apples == Oranges)
            {
                Console.WriteLine("both {0}", Apples);
            }
        }
    }
}
