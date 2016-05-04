using System;

    class IndexOfLetters
    {
        static void Main()
        {
            string word = Console.ReadLine();

            foreach(char c in word)
            {
                Console.WriteLine(c - 97); //97 = a in ASCII
            }

        }
    }

