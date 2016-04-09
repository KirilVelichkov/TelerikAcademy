using System;

class Circle
{
    static void Main(string[] args)
    {
       
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double DISTANCE = Math.Sqrt(((x * x) - 0) + ((y * y) - 0));
        
        if (DISTANCE <= 2)
        {
            Console.WriteLine("yes " + "{0:0.00}", DISTANCE);
        }
        else 
        {
            Console.WriteLine("no " + "{0:0.00}", DISTANCE); 
        }
        
    }
}

