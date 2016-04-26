using System;


class Batman
{
    static void Main()
    {
        int s = int.Parse(Console.ReadLine());
        char c = char.Parse(Console.ReadLine());
        int width = 3 * s;
        int wings_ears = ((width - ((s - 1) * 2) - 2) / 2) - 1;

        //print top;
        for (int i = 1; i <= (s / 2); i++)
        {
            Console.Write(new string(' ', i - 1));
            Console.Write(new string(c, (s + 1) - i));
            if (i != (s / 2))
            {
                Console.Write(new string(' ', s));
            }
            else
            {
                Console.Write(new string(' ', wings_ears));
                Console.Write(new string(c, 1));
                Console.Write(new string(' ', 1));
                Console.Write(new string(c, 1));
                Console.Write(new string(' ', wings_ears));
            }
            Console.Write(new string(c, (s + 1) - i));
            Console.Write(new string(' ', i - 1));
            Console.WriteLine();
        }

        //print middle
        for (int i = 1; i <= (s / 3); i++)
        {
            Console.Write(new string(' ', s / 2));
            Console.Write(new string(c, (s * 2) + 1));
            Console.Write(new string(' ', s / 2));
            Console.WriteLine();
        }

        //print bottom
        for (int i = 1; i <= (s / 2); i++)
        {
            Console.Write(new string(' ', (width - (s - (i * 2))) / 2));
            Console.Write(new string(c, s - (i * 2)));
            Console.Write(new string(' ', (width - (s - (i * 2))) / 2));
            Console.WriteLine();
        }
    }


}

