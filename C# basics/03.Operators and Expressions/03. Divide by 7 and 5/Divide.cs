using System;

class Divide
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        if((n%7==0) && (n%5 == 0))
        {
            Console.WriteLine("true {0}", n);
        }
        else
        {
            Console.WriteLine("false {0}", n);
        }
    }
}

