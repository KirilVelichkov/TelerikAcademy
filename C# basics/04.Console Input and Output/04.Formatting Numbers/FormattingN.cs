using System;
using System.Globalization;
using System.Threading;

public class FormattingN
{
    public static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InstalledUICulture;

        uint firstNumber = uint.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());

        var firstToBinary = Convert.ToString(firstNumber, 2).PadLeft(10, '0');

        string output = "{0,-10:X}|{1}|{2,10:F2}|{3,-10:F3}|";

        Console.WriteLine(output, firstNumber, firstToBinary, secondNumber, thirdNumber);
    }
}