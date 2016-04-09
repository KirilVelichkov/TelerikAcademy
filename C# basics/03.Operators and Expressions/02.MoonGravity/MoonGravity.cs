using System;

class MoonGravity
{
    static void Main(string[] args)
    {
        double W = double.Parse(Console.ReadLine());
        double Gravity = ((W / 100) * 17);
        Console.WriteLine(Gravity.ToString("F3"));
    }
}

