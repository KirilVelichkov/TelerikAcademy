using System;
using System.Numerics;
using System.Text;

class OneSysToOther
{
    /*




    */
    static string ReverseStringFromStringBuilder(StringBuilder tobeReversed)
    {
        var reverseResult = new StringBuilder();

        string reverse = tobeReversed.ToString();
        for (int i = reverse.Length - 1; i >= 0; i--)
        {
            reverseResult.Append((reverse[i]));
        }

        return reverseResult.ToString();
    }

    static BigInteger ConvertFromAnyToDecimal(string number, int currentBase)
    {
        string characters = "0123456789ABCDEF";

        int length = number.Length;
        BigInteger result = 0;
        for (int i = 0; i < length; i++)
        {
            result = result * currentBase + characters.IndexOf(number[i]);
        }

        return result;
    }

    public static string ConvertFromAnyNumeralSystemToAnother(BigInteger number, int numeralSystem)
    {
        var result = new StringBuilder();
        while (number != 0)
        {
            int digit = (int)(number % numeralSystem);
            number /= numeralSystem;
            if (digit >= 0 && digit <= 9)
            {
                result.Append(digit);
            }
            if (digit >= 10 && digit <= numeralSystem)
            {
                result.Append(Convert.ToChar(digit + 55));
            }
        }

        return ReverseStringFromStringBuilder(result);
    }

    static void Main()
    {
        int currentBase = int.Parse(Console.ReadLine());
        var number = Console.ReadLine().ToUpper();
        int numeralSystem = int.Parse(Console.ReadLine());

        BigInteger currentDecimal = 0;

        currentDecimal = ConvertFromAnyToDecimal(number, currentBase);

        Console.WriteLine(ConvertFromAnyNumeralSystemToAnother(currentDecimal, numeralSystem));
    }
}