using System;

class ThirdBit
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine()); //15 //00001111
        int p = 3;
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(8, '0')); //00001111

        int mask = 1 << p;
        Console.WriteLine(Convert.ToString(mask, 2).PadLeft(8, '0')); //00001000
        int nAndMask = n & 1 << p;
        Console.WriteLine(Convert.ToString(nAndMask, 2).PadLeft(8, '0')); //00001000
        int bit = nAndMask >> p;
        Console.WriteLine(Convert.ToString(bit, 2).PadLeft(8, '0')); //00000001
        Console.WriteLine(bit);
        Main();
    }
}
