using System;

public class FibonacciNumbers
{
    public static void Main()
    {
        int length = int.Parse(Console.ReadLine());

        long current;
        long previous = 1;
        long beforePrevious = 0;

        for (int i = 0; i < length; i++)
        {
            if (i == 0)
            {
                current = beforePrevious;
            }
            else if (i == 1)
            {
                current = previous;
            }
            else
            {
                current = beforePrevious + previous;
                beforePrevious = previous;
                previous = current;
            }

            if (i < length - 1)
            {
                Console.Write("{0}, ", current);
            }
            else
            {
                Console.Write(current);
            }

        }
    }
}