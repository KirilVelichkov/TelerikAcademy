using System;

class OddEven
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        if (n % 2 == 0)
        {
            Console.WriteLine("even {0}", n);
        }
        else
        {
            Console.WriteLine("odd {0}", n);
        }
    }
}

