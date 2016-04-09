using System;

class BitExchange
{

    static void Main()
    {
        uint N = uint.Parse(Console.ReadLine());
        uint third = (N & (1 << 3)) >> 3;
        uint fourth = (N & (1 << 4)) >> 4;
        uint fifth = (N & (1 << 5)) >> 5;
        uint changeThird = (N & (1 << 24)) >> 24;
        uint changeFourth = (N & (1 << 25)) >> 25;
        uint changeFifth = (N & (1 << 26)) >> 26;

        uint mask = 0;

        if (third == 0)
        {
            mask = ~((uint)1 << 24);
            N = (N & mask);
        }
        else
        {
            mask = ((uint)1 << 24);
            N = (N | mask);
        }
        if (fourth == 0)
        {
            mask = ~((uint)1 << 25);
            N = (N & mask);
        }
        else
        {
            mask = ((uint)1 << 25);
            N = (N | mask);
        }
        if (fifth == 0)
        {
            mask = ~((uint)1 << 26);
            N = (N & mask);
        }
        else
        {
            mask = ((uint)1 << 26);
            N = (N | mask);
        }
        

        if (changeThird == 0)
        {
            mask = ~((uint)1 << 3);
            N = (N & mask);
        }
        else
        {
            mask = ((uint)1 << 3);
            N = (N | mask);
        }
        if (changeFourth == 0)
        {
            mask = ~((uint)1 << 4);
            N = (N & mask);
        }
        else
        {
            mask = ((uint)1 << 4);
            N = (N | mask);
        }
        if (changeFifth == 0)
        {
            mask = ~((uint)1 << 5);
            N = (N & mask);
        }
        else
        {
            mask = ((uint)1 << 5);
            N = (N | mask);
        }

        Console.WriteLine(N);
      
    }
}

