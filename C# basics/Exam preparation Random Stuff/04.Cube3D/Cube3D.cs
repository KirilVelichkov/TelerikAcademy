using System;


class Program
{

    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int width = N * 2 - 1;
        int height = width;
        //   :::::    
        //   :   ::
        //   :   :|:  
        //   :   :||: 
        //   :::::|||:
        //    :---:||:
        //     :---:|:
        //      :---::
        //       :::::

        char[,] cube = new char[width, height];
        for (int row = 0; row < N - 1; row++)
        {
            for (int col = 0; col < N - 1; col++)
            {
                cube[row, N + col] = ' ';
                cube[row+N, col] = ' ';
            }
        }
        for (int col = 0; col < N; col++)
        {
            cube[0, col] = ':';
            cube[N - 1, col] = ':';
            cube[height - 1, col + N - 1] = ':';
        }
        for (int row = 0, col = 0; row < width; row++)
        {
            if (row > N - 1)
            {
                col++;
            }
            cube[row, col] = ':';
            cube[row, col + N - 1] = ':';
            if (row < N)
            {
                cube[row, N + row - 1] = ':';
            }
            else
            {
                cube[row, width - 1] = ':';
            }
        }
        for (int i = 0; i < N - 2; i++)
        {
            for (int row = 2; row < N; row++)
            {
                cube[row + i, N + i] = '|';
                cube[N + i, row + i] = '-';
                cube[i + 1, row - 1] = ' ';
            }
        }
      
        Print(cube);
    }
    static void Print(char[,] cube)
    {
        for (int row = 0; row < cube.GetLength(0); row++)
        {
            for (int col = 0; col < cube.GetLength(1); col++)
            {
                Console.Write(cube[row, col]);
            }
            Console.WriteLine();
        }
    }
}
