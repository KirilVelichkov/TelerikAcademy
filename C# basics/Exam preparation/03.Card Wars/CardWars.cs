using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Card_Wars
{
    class CardWars
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            string[] player1 = new string[3];
            string[] player2 = new string[3];
            int player1cardZ = 1;
            int player1cardY = -200;
            bool player1cardX = false;
            int player2cardZ = 1;
            int player2cardY = -200;
            bool player2cardX = false;
            int player1Score = 0;
            int player2Score = 0;
            int player1Games = 0;
            int player2Games = 0;
            for (int i = 1; i <= N; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    player1[j] = Console.ReadLine();
                    for (int k = 2; k <= 10; k++)
                    {
                        if(player1[j] == k.ToString())
                        {
                            player1Score += 12 - k;
                        }
                    }
                    switch (player1[j])
                    {
                        case "A":
                            player1Score += 1;
                            break;
                        case "J":
                            player1Score += 11;
                            break;
                        case "Q":
                            player1Score += 12;
                            break;
                        case "K":
                            player1Score += 13;
                            break;
                        case "Z":
                            player1cardZ++;
                            player1Score *= (int)Math.Pow(2, player1cardZ);
                            break;
                        case "Y":
                            player1cardY += -200;
                            player1Score += player1cardY;
                            break;
                        case "X":
                            player1cardX = true;
                            break;
                    }
                }
                for (int j = 0; j < 3; j++)
                {
                    player2[j] = Console.ReadLine();
                    for (int k = 2; k <= 10; k++)
                    {
                        if (player2[j] == k.ToString())
                        {
                            player2Score += 12 - k;
                        }
                    }
                    switch (player2[j])
                    {
                        case "A":
                            player2Score += 1;
                            break;
                        case "J":
                            player2Score += 11;
                            break;
                        case "Q":
                            player2Score += 12;
                            break;
                        case "K":
                            player2Score += 13;
                            break;
                        case "Z":
                            player2cardZ++;
                            player2Score *= (int)Math.Pow(2, player2cardZ);
                            break;
                        case "Y":
                            player2cardY += -200;
                            player2Score += player2cardY;
                            break;
                        case "X":
                            player2cardX = true;
                            break;
                    }
                }
                if(player1Score > player2Score)
                {
                    player1Games++;
                }
                if(player2Score > player1Score)
                {
                    player2Games++;
                }
            }
            if(player1cardX && !player2cardX)
            {
                Console.WriteLine("X card drawn! Player one wins the match!");
            }
            if (!player1cardX && player2cardX)
            {
                Console.WriteLine("X card drawn! Player two wins the match!");
            }
            if (!player1cardX && !player2cardX)
            {
                if(player1Games > player2Games)
                {
                    Console.WriteLine("First player wins!");
                    Console.WriteLine();
                    Console.WriteLine("Score: {0}",player1Score);
                    Console.WriteLine();
                    Console.WriteLine("Games won {0}",player1Games);
                }
                if (player1Games < player2Games)
                {
                    Console.WriteLine("Second player wins!");
                    Console.WriteLine();
                    Console.WriteLine("Score: {0}", player2Score);
                    Console.WriteLine();
                    Console.WriteLine("Games won {0}", player2Games);
                }
                if (player1Games == player2Games)
                {
                    Console.WriteLine("It's a tie!");
                    Console.WriteLine();
                    Console.WriteLine("Score: {0}", player2Score + player1Score);
                }
            }
        }
    }
}
