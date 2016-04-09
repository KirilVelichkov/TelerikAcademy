using System;

class Point
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        bool circle = (Math.Pow(x - 1, 2) + Math.Pow(y - 1, 2)) <= Math.Pow(1.5, 2);
        bool rect = ((x < -1) || (x > 5) || (y > 1) || (y < -1));

        string strCircle = "outside circle";
        string strRect = "outside rectangle";

        if (circle)
        {
            strCircle = "inside circle";
        }
        if (!rect)
        {
            strRect = "inside rectangle";
        }
        Console.WriteLine("{0} {1}", strCircle, strRect);
    }
}

