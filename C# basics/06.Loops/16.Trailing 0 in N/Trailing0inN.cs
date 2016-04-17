using System;
using System.Numerics;
using System.Text.RegularExpressions;

public class TralingZeroInNFactorial
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int zerosCounter = 0;
        int divider = 5;
        while (number / divider >= 1)
        {
            zerosCounter += number / divider;
            divider *= 5;
        }

        Console.WriteLine(zerosCounter);
    }
}