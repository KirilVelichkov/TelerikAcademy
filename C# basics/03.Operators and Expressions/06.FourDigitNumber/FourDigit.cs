using System;

class FourDigit
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int a = (N / 1000) % 10;
        int b = (N / 100) % 10;
        int c = (N / 10) % 10;
        int d = N % 10;
        Console.WriteLine(a + b + c + d);
        Console.WriteLine("{0}{1}{2}{3}", d, c, b, a);
        Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);
        Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);
    }
}

