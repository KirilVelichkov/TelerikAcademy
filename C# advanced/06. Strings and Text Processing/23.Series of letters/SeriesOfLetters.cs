using System;
using System.Linq;

namespace _23.Series_of_letters
{
    class SeriesOfLetters
    {
        static void Main()
        {
            string input = Console.ReadLine();

            input.Distinct().Select(c => c.ToString()).ToList()
                    .ForEach(c =>
                    {
                        while (input.Contains(c + c))
                            input = input.Replace(c + c, c);
                    }
                    );
            Console.WriteLine(input);

        }
    }
}
