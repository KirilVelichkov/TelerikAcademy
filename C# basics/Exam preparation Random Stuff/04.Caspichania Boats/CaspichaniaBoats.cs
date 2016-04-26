using System;


class CaspichaniaBoats
{

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int width = n * 2 + 1;
        int height = 6 + ((n - 3) / 2) * 3;

        
        #region print top 2 rows;
        for (int i = 0; i < 2; i++)
        {
            //print top 2 rows;
            for (int j = 0; j < width; j++)
            {
                if (i == 0)
                {
                    if (j != n)
                    {
                        Console.Write('.');
                    }
                    else
                    {
                        Console.Write('*');
                    }
                }
                else
                {
                    if (j == n || j == n - 1 || j == n + 1)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('.');

                    }
                }
            }
            Console.WriteLine();
        }
        #endregion

        //print top
        for (int j = 0; j < n - 2; j++)
        {
            Console.Write(new string('.', n - j - 2));
            Console.Write('*');
            Console.Write(new string('.', j + 1));
            Console.Write('*');
            Console.Write(new string('.', j + 1));
            Console.Write('*');
            Console.Write(new string('.', n - j - 2));
            Console.WriteLine();
        }

        //print middle row;
        for (int i = 0; i < width; i++)
        {

            Console.Write('*');
        }
        Console.WriteLine();
        //print bottom 1
        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(new string('.', i + 1));
            Console.Write('*');
            Console.Write(new string('.', n - 2 - i));
            Console.Write('*');
            Console.Write(new string('.', n - 2 - i));
            Console.Write('*');
            Console.Write(new string('.', i + 1));
            Console.WriteLine();
        }

        //print bottom 2
        Console.Write(new string('.', (n / 2) + 1));
        Console.Write(new string('*', n));
        Console.Write(new string('.', (n / 2) + 1));



    }
}

