using System;



class Pages
{
    static void Main()
    {
        int digits = int.Parse(Console.ReadLine());
        int N = 0;
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

