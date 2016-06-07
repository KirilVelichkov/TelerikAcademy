using System;
using System.Linq; // needed for Where()

class ExtractSentences
{
    static void Main()
    {
        string wordSearch = Console.ReadLine().Trim();
        string text = Console.ReadLine();

        string[] sentences = text
            .Split(new string[] { "." }, StringSplitOptions.RemoveEmptyEntries);
        char[] separators = GetNonLetterSymbols(text);

        foreach (string sentence in sentences)
        {
            string[] words = sentence
                .Split(separators, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                if (word.Trim() == wordSearch)
                {
                    Console.Write(sentence.Trim() + ". ");
                    break;
                }
            }
        }

    }

    private static char[] GetNonLetterSymbols(string input)
    {
        char[] symbols = input
            .Where(ch => !char.IsLetter(ch) && ch != '.') // needs System.Linq
            .Distinct() // removes all duplicate elements in a collection; returns only the distinct elements
            .ToArray();

        return symbols;
    }
}