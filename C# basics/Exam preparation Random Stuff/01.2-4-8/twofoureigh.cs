using System;
using System.Numerics;


class TwoFourEigh
{
    static void Main()
    {
        BigInteger a = BigInteger.Parse(Console.ReadLine());
        BigInteger b = BigInteger.Parse(Console.ReadLine());
        BigInteger c = BigInteger.Parse(Console.ReadLine());
        BigInteger temp = 0;
        BigInteger result1 = 0;
        BigInteger result2 = 0;
        if(b == 2)
        {
            result1 = a % c;
        }
        else if(b == 4)
        {
            result1 = a + c;
        }
        else if(b == 8)
        {
            result1 = a * c;
        }
        result2 = result1;
        temp = result1;
        if (result1 % 4 == 0)
        {
            temp /= 4;
            Console.WriteLine(temp);
        }
        else
        {
            temp %= 4;
            Console.WriteLine(temp);
        }
        
        Console.WriteLine(result2);
    }
}
