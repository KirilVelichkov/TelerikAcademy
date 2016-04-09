using System;

//Write a program that reads from the console two integer numbers P and N and prints on the console the value of P's N-th bit. 

//Input : On the first line you will receive the number P.On the second line you will receive the number N.

//Output : Output a single value - the value of the N-th bit in P.

class NthBit
{
    static void Main()
    {
        ulong P = ulong.Parse(Console.ReadLine());
        byte N = byte.Parse(Console.ReadLine());

        uint mask = (uint)(1 << N);//0001 0000
        //Console.WriteLine(Convert.ToString(mask, 2).PadLeft(8, '0'));
        ulong nAndMask = (ulong)(P & mask); //0000 1111 - 0000 0000
        // Console.WriteLine(Convert.ToString((int)nAndMask, 2).PadLeft(8, '0'));
        ulong bit = nAndMask >> N;
        // Console.WriteLine(Convert.ToString((int)bit, 2).PadLeft(8, '0'));
        Console.WriteLine(bit);

    }
}