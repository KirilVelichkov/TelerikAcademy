using System;
using System.Linq;

class LargestArea
{
    static int[][] matrix;
    static bool[,] visited;
    static int[] dx = { -1, 1, 0, 0 };
    static int[] dy = { 0, 0, -1, 1 };
    static int[] N_M;


    static int bfs(int x, int y, int value)
    {
        if (visited[x, y])
        {
            return 0;
        }
        else
        {
            visited[x, y] = true;
            int sum = 1;
            for (int i = 0; i < 4; i++)
            {
                int newx = dx[i] + x;
                int newy = dy[i] + y;
                if (newx == -1 || newy == -1 || newx >= N_M[0] || newy >= N_M[1])
                {
                    continue;
                }
                if (matrix[newx][newy] == value)
                {
                    int c = bfs(newx, newy, value);
                    sum += c;
                }
            }
            return sum;
        }
    }

    static void Main()
    {
        N_M = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        matrix = new int[N_M[0]][];
        visited = new bool[N_M[0], N_M[1]];
        int current = 1;
        int max = 1;

        for (int j = 0; j < N_M[0]; j++)
        {
            matrix[j] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        }

        for (int row = 0; row < N_M[0]; row++)
        {
            for (int col = 0; col < N_M[1]; col++)
            {
                if(visited[row,col] == false)
                {
                    current = bfs(row, col, matrix[row][col]);
                    if(current > max)
                    {
                        max = current;
                    }
                }
            }
        }
        Console.WriteLine(max);
    }
}