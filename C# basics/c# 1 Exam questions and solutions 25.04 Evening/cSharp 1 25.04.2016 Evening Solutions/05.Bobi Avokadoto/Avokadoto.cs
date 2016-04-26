using System;
using System.Linq;


class BobiAvokadoto
{
    static void Main()
    {
        uint head = uint.Parse(Console.ReadLine());
        uint numberOfCombs = uint.Parse(Console.ReadLine());

        uint[] combs = new uint[99999];
        uint[] bestComb = new uint[99999];

        uint temp = numberOfCombs;
        uint[] counter = new uint[99999];

        uint headOnes = 0;
        uint combOnes = 0;

        while (numberOfCombs > 0)
        {
            combs[(temp + 1) - numberOfCombs] = uint.Parse(Console.ReadLine());
            numberOfCombs--;
        }


        for (uint j = 1; j <= temp; j++)
        {
            for (uint i = 0; i < 32; i++)
            {
                headOnes = BitInPossition(head, i);
                combOnes = BitInPossition(combs[j], i);
                if (headOnes == 1 && combOnes == 1)
                {
                    break;
                }
                if (headOnes == 0 && combOnes == 1)
                {
                    counter[j]++;
                }
            }
            bestComb[j] = counter[j];
        }
        uint maxValue = bestComb.Max();
        uint maxIndex = (uint)bestComb.ToList().IndexOf(maxValue);
        Console.WriteLine(combs[maxIndex]);

    }


    public static uint BitInPossition(uint number, uint bitPossition)
    {
        int mask = 1 << (int)bitPossition;
        uint c = (number & (uint)mask) >> (int)bitPossition;
        return c;
    }
}

