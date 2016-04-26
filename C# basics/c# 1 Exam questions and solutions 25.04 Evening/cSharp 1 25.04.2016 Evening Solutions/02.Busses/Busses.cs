using System;


class Busses
{
    static void Main()
    {
        int c = int.Parse(Console.ReadLine()); //number of busses
        int counter = 1;
        int busSpeeds = int.Parse(Console.ReadLine());
        for (int i = 1; i < c; i++)
        {
            int speed = int.Parse(Console.ReadLine());
            if (speed > busSpeeds)
            {
                continue;
            }
            else
            {
                counter++;
                busSpeeds = speed;
            }
        }
        Console.WriteLine(counter);
    }
}
