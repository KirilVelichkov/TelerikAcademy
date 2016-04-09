using System;

/*
We are given an integer number 
N(read from the console), 
a bit value v(read from the console as well) (v = 0 or 1) 
and a position P(read from the console). 
Write a sequence of operators (a few lines of C# code) 
that modifies N to hold the value v at the position P from the binary representation of N while preserving all other bits in N. 

Print the resulting number on the console.
*/


class ModifyBit
{
    static void Main()
    {
        ulong N = ulong.Parse(Console.ReadLine());
        byte P = byte.Parse(Console.ReadLine());
        byte v = byte.Parse(Console.ReadLine());
        ulong mask = 0;
        ulong result = 0;

        if (v == 0)
        {
            mask = ~((ulong)1 << P);
            result = (N & mask);
        }
        else
        {
            mask = ((ulong)1 << P);
            result = (N | mask);
        }

        Console.WriteLine(result);

    }
}

