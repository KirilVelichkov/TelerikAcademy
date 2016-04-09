using System;

class ThirdDigit
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine((N / 100) % 10 == 7 ? "true" : "false " + (N / 100) % 10);
    }
}

