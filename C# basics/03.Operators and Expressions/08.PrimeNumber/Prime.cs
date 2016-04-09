using System;

class Prime
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        string isPrime = "true";

        if (number < 2)
        {
            isPrime = "false";
        }
         

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                isPrime = "false";
                break;
            }
        }

        Console.WriteLine(isPrime);
    }
}


