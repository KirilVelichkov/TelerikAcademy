using System;


class Batman
{
    static void Main()
    {
        int s = int.Parse(Console.ReadLine());
        char c = char.Parse(Console.ReadLine());

        //print ears
        Console.Write(new string(' ', 1));
        Console.Write(new string(c, 1));
        Console.Write(new string(' ', s / 4 - 1));
        Console.Write(new string(c, 1));
        Console.WriteLine();
        //print head
        for (int i = 0; i < s / 4 - 1; i++)
        {
            Console.Write(new string(' ', 1)); //maybe not 1
            Console.Write(new string(c, s / 4+1));
            Console.WriteLine();
        }
        //print neck 1
        for (int i = 0; i < s / 4 - 1; i++)
        {
            Console.Write(new string(' ', 2)); //maybe not 2
            Console.Write(new string(c, (s / 4) - 1));
            Console.WriteLine();
        }
        //print neck 2
        for (int i = 0; i < s / 4; i++)
        {
            Console.Write(new string(' ', 1)); //maybe not 1
            Console.Write(new string(c, s / 4 + 1));
            if(i== s / 4 - 1)
            {
                Console.Write(new string(' ', 3)); //maybe not 3
                Console.Write(new string(c, s / 4));
            }
            Console.WriteLine();
        }
        //print bottom with tail
        // ### #
        // ### #
        // ### #
        for (int i = 0; i < s / 4 + 2; i++)
        {
            Console.Write(new string(c, (s / 3) + 2));
            if(i < s/4 + 1)
            {
                Console.Write(new string(' ', 2)); //maybe not 2
                Console.Write(new string(c, 1));
            }
            else
            {
                Console.Write(new string(' ', 1)); //maybe not 2
                Console.Write(new string(c, 2));
            }
            Console.WriteLine();
        }
        //print legs
        Console.Write(new string(' ', 1));
        Console.Write(new string(c, (s / 3) + 3));


        //    int s = int.Parse(Console.ReadLine());
        //    char c = char.Parse(Console.ReadLine());
        //    int width = 3 * s;
        //    int wings_ears = ((width - ((s - 1) * 2) - 2) / 2) - 1;

        //    //print top;
        //    for (int i = 1; i <= (s / 2); i++)
        //    {
        //        Console.Write(new string(' ', i - 1));
        //        Console.Write(new string(c, (s + 1) - i));
        //        if (i != (s / 2))
        //        {
        //            Console.Write(new string(' ', s));
        //        }
        //        else
        //        {
        //            Console.Write(new string(' ', wings_ears));
        //            Console.Write(new string(c, 1));
        //            Console.Write(new string(' ', 1));
        //            Console.Write(new string(c, 1));
        //            Console.Write(new string(' ', wings_ears));
        //        }
        //        Console.Write(new string(c, (s + 1) - i));
        //        Console.Write(new string(' ', i - 1));
        //        Console.WriteLine();
        //    }

        //    //print middle
        //    for (int i = 1; i <= (s / 3); i++)
        //    {
        //        Console.Write(new string(' ', s / 2));
        //        Console.Write(new string(c, (s * 2) + 1));
        //        Console.Write(new string(' ', s / 2));
        //        Console.WriteLine();
        //    }

        //    //print bottom
        //    for (int i = 1; i <= (s / 2); i++)
        //    {
        //        Console.Write(new string(' ', (width - (s - (i * 2))) / 2));
        //        Console.Write(new string(c, s - (i * 2)));
        //        Console.Write(new string(' ', (width - (s - (i * 2))) / 2));
        //        Console.WriteLine();
        //    }
        //

    }
}

