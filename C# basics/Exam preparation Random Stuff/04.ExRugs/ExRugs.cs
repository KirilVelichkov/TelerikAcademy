using System;

class ExRugs
{
    private static int i;

    static void Main()
    {

       // int N = int.Parse(Console.ReadLine());
        //int D = int.Parse(Console.ReadLine());

        int width = 5;
        int height = 5;
        char hash = '#';
        char[,] rug = new char[height, width];

        rug[1, 1] = 'a';
        rug[2, 3] = 'b';
        rug[4, 4] = 'c';
        Print(rug);
        Print(rug);
    }
    static void Print(char[,] rug)
    {
        for (int row = 0; row < rug.GetLength(0); row++)
        {
            for (int col = 0; col < rug.GetLength(1); col++)
            {
                Console.Write(rug[row,col]);
            }
            Console.WriteLine();
        }
    }
}
