using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Polinomials
{
    static int[] GetArrayFromInput(string input)
    {
        var resultArray = input
            .Split(' ')
            .Select(z => Convert.ToInt32(z))
            .ToArray();

        return resultArray;
    }

    static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        var firstPolinomials = Console.ReadLine();
        var polinomialsOne = GetArrayFromInput(firstPolinomials);

        var secondPolinomials = Console.ReadLine();
        var polinomialsTwo = GetArrayFromInput(secondPolinomials);

        var resultPolinomials = new int[n];

        for (int i = 0; i < n; i++)
        {
            resultPolinomials[i] = polinomialsOne[i] + polinomialsTwo[i];
        }

        Console.WriteLine(string.Join(" ", resultPolinomials));
    }
}