using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Person
{
    private string name;
    private int age;


    public string name2 { get;  }
    public int age2 { get; set; }

    public const int number = 17;

    public Person()
    {
        this.name = "Unnamed";
        this.age = -1;
    }

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public string GetName()
    {
        return this.name;
    }

    public int GetAge()
    {
        return this.age;
    }
}

class demo1
{

    static void Main()
    {
        Random randomGenerator = new Random();
        int[] a = new int[10];
        a[4] = 7;
        int[] b = (int[])a.Clone();
        a[4] = 9;
        Console.WriteLine(a[4]);

        //26,39 slide
        Person p1 = new Person("Pesho", 42);

        //---
        Console.WriteLine(p1.GetName());
        Console.WriteLine(p1.GetAge());

        //---
        Person p2 = new Person();
        Console.WriteLine(p2.GetName());
        Console.WriteLine(p2.GetAge());

        //---
        Console.WriteLine(Person.number);

        //---
        p1.age2++;

        Console.WriteLine(p1.name2);
        Console.WriteLine(p1.age2);

    }
}

