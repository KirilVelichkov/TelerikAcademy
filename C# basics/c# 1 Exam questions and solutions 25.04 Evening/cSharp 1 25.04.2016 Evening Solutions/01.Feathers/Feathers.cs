using System;



class Feathers

{
    static void Main()
    {
        double B = double.Parse(Console.ReadLine());
        double F = double.Parse(Console.ReadLine());
        double average = F / B;
        double result = 0;

        if (B % 2 != 0) //ODD
        {
            result = average / 317;
        }
        else //EVEN
        {
            result = average * 123123123123;
        }
        Console.WriteLine("{0:F4}", result);
        //)  * 123123123123
        // ) / 317
    }
}

