using System;


class PrimeNumbers
{
    static int IsPrime(int number)
    {
        if (number <= 1) return 0; // zero and one are not prime
        int i;
        for (i = 2; i * i <= number; i++)
        {
            if (number % i == 0) return 0;
        }
        return 1;
    }
    static void Main()
    {

        int number = int.Parse(Console.ReadLine());
        byte prime = 0;
        int result = 0;
        if (number < 3)
        {
            result = 2;
        }
        else
        {

            for (int i = number - 50000; i <= number; i++)
            {
                prime = (byte)IsPrime(i);
                if (prime == 1)
                {
                    result = i;
                }
            }
        }
        Console.WriteLine(result);
    }
}