using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Hello
{
    static void Main()
    {
        string name = Console.ReadLine();

        Console.WriteLine("Hello, {0}!", SayHello(name));
    }

    static string SayHello(string name)
    {
        return name;
    }

}

