using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Threading;

namespace _12.Falling_Rocks
{
    struct Rocks
    {
        public int col;
        public int row;
        public char symbol;
        public ConsoleColor color;
    }
    class FallingRocks
    {
        static void PrintPosition(int col, int row, char c, ConsoleColor color = ConsoleColor.Gray)
        {
            Console.SetCursorPosition(col, row);
            Console.ForegroundColor = color;
            Console.Write(c);
        }
        static void PrintScoreBoard(int col, int row, string str, ConsoleColor color = ConsoleColor.Gray)
        {
            Console.SetCursorPosition(col, row);
            Console.ForegroundColor = color;
            Console.Write(str);
        }
        static void Main()
        {
            int playfieldWidth = 40;
            int livesCount = 3;
            int count = 0;
            int score = 0;
            int level = 1;
            Console.BufferHeight = Console.WindowHeight = 15;
            Console.BufferWidth = Console.WindowWidth = 60;
            Rocks dwarf = new Rocks();
            dwarf.col = 20;
            dwarf.row = Console.WindowHeight - 1;
            dwarf.symbol = '@';
            dwarf.color = ConsoleColor.Green;
            Console.SetCursorPosition(dwarf.col, dwarf.row);
            //PrintPosition(dwarf.col, dwarf.row, dwarf.symbol, dwarf.color);
            Random RNG = new Random();
            List<Rocks> rocks = new List<Rocks>();
            
            while (true)
            {
                bool hitted = false;
                {
                    Rocks newRocks = new Rocks();
                    newRocks.color = ConsoleColor.Magenta;
                    newRocks.col = RNG.Next(0, playfieldWidth);
                    newRocks.row = 0;
                    newRocks.symbol = '#';
                    rocks.Add(newRocks);
                    newRocks.color = ConsoleColor.Yellow;
                    newRocks.col = RNG.Next(0, playfieldWidth);
                    newRocks.row = 0;
                    newRocks.symbol = '$';
                    rocks.Add(newRocks);
                    newRocks.color = ConsoleColor.Blue;
                    newRocks.col = RNG.Next(0, playfieldWidth);
                    newRocks.row = 0;
                    newRocks.symbol = '!';
                    rocks.Add(newRocks);
                }
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                    while (Console.KeyAvailable) Console.ReadKey(true);
                    if (pressedKey.Key == ConsoleKey.LeftArrow)
                    {
                        if (dwarf.col - 1 >= 0)
                        {
                            dwarf.col--;
                        }
                    }
                    if (pressedKey.Key == ConsoleKey.RightArrow)
                    {
                        if (dwarf.col - 1 <= playfieldWidth)
                        {
                            dwarf.col++;
                        }
                    }
                }
                List<Rocks> newList = new List<Rocks>();
                for (int i = 0; i < rocks.Count; i++)
                {
                    Rocks oldRock = rocks[i];
                    Rocks newRocks = new Rocks();
                    newRocks.col = oldRock.col;
                    newRocks.row = oldRock.row + 1;
                    newRocks.symbol = oldRock.symbol;
                    newRocks.color = oldRock.color;
                    if (newRocks.col == dwarf.col && newRocks.row == dwarf.row)
                    {
                        hitted = true;
                        Console.Beep();
                        livesCount--;
                        if (livesCount < 1)
                        {
                            Console.Beep(1000,500);
                            PrintScoreBoard(playfieldWidth / 2, Console.WindowHeight / 2, "GAME OVER!", ConsoleColor.Red);
                            PrintScoreBoard(playfieldWidth / 2, Console.WindowHeight / 2 + 2, "Press [enter] to exit!", ConsoleColor.Red);
                            Console.ReadLine();
                            return;
                        }
                    }
                    if (newRocks.row < Console.WindowHeight)
                    {
                        newList.Add(newRocks);
                    }
                    //Score count
                     if(newRocks.row > Console.WindowHeight-1)
                    {
                        count++;
                    }
                }

                rocks = newList;
                Console.Clear();
                
                foreach (Rocks rock in rocks)
                {
                    PrintPosition(rock.col, rock.row, rock.symbol, rock.color);
                }
                if (hitted)
                {
                    PrintPosition(dwarf.col, dwarf.row, 'X', ConsoleColor.Red);
                }
                else
                {
                    PrintPosition(dwarf.col, dwarf.row, dwarf.symbol, dwarf.color);
                }
                score = count / 3;
                if (score != 0)
                {
                    if (score % 50 == 0)
                    {
                        level++;
                    }
                }
                PrintScoreBoard(47, 3, "Lives:", ConsoleColor.Green);
                PrintScoreBoard(49, 4, "" + livesCount, ConsoleColor.Green);
                PrintScoreBoard(47, 6, "Level:", ConsoleColor.Green);
                PrintScoreBoard(49, 7, "" + level, ConsoleColor.Green);
                PrintScoreBoard(47, 9, "Score:", ConsoleColor.Green);
                PrintScoreBoard(49, 10, "" + score, ConsoleColor.Green);
                for (int i = 0; i < Console.WindowHeight; i++)
                {
                    PrintScoreBoard(41, i, "|", ConsoleColor.DarkGray);
                }
                Thread.Sleep(200-level);
            }
        }
    }
}
