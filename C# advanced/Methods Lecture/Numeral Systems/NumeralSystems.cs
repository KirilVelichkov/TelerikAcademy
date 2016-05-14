

namespace Numeral_Systems
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class NumeralSystems
    {
        static void Main()
        {
            //Decimal to Binary
            var numberInDecimal = 100;
            var numberInBinaryDOTNET = Convert.ToString(numberInDecimal, 2);

            var numberInBinaryCustom = DecimalToBinary(numberInDecimal);

            Console.WriteLine(numberInBinaryCustom);
        }

        static string DecimalToBinary(int number)
        {
            var builder = new StringBuilder();
            var remainder = 0;
            var toBase = 2;

            while (number != 0)
            {
                remainder = number % toBase;
                number = number / toBase;
                builder.Append(remainder.ToString());
            }
           var numberInBinary =  Reverse(builder.ToString());

            return numberInBinary;
        }
        static string Reverse(string sequence)
        {
            var sequenceAsCharArray = sequence.ToCharArray();
            Array.Reverse(sequenceAsCharArray);

            return String.Join(string.Empty, sequenceAsCharArray);
        }

        static TimeSpan Benchmark(Func<int, string> method)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 1000000; i++)
            {
                method(i);
            }
            stopwatch.Stop();

            return stopwatch.Elapsed;
        }
    }
}
