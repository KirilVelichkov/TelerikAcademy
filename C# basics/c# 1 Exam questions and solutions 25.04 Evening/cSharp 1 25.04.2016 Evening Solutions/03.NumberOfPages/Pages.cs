using System;



class Pages
{
    static void Main()
    {
        int digits = int.Parse(Console.ReadLine());
        int N = 0;
        int[] multiplier = new int[8];
        multiplier[1] = 1;
        multiplier[2] = 2;
        multiplier[3] = 3;
        multiplier[4] = 4;
        multiplier[5] = 5;
        multiplier[6] = 6;
        multiplier[7] = 7;
        int check = 0;
        int check2 = 0;
        for (int i = 1; i <= 1000000; i++)
        {

            if (N == digits)
            {
                break;
            }
            check = i.ToString().Length;
            N += check;
            check2 = i;

        }
        Console.WriteLine(check2);
    }
}

