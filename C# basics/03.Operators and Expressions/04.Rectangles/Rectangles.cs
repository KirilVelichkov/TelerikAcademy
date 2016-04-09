using System;

class Rectangles
{
    static void Main(string[] args)
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double area = width * height;
        double perimeter = (width * 2) + (height * 2);

        Console.WriteLine(area.ToString("F2") + " " + perimeter.ToString("F2"));
    }
}

