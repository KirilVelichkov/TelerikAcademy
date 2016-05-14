

namespace Methods
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int>()
            {
                10,1,2,5,-3,3,2,7,9,1,2
            };

            InvokeMethod2(AddNumbersAndReturnResultAsString, 10, 5);

            //PrintArray(numbers);
            //SelectionSort(numbers);
            //PrintArray(numbers);
            //InvokeMethod(Introduce);
           
        }


        //static void PrintArray(List<int> numbers)
        //{
        //    for (int i = 0; i < numbers.Count; i++)
        //    {
        //        Console.Write("{0} ", numbers[i]);
        //    }
        //    Console.WriteLine();
        //}

        //static void SelectionSort(List<int> numbers)
        //{
        //    for (int i = 0; i < numbers.Count - 1; i++)
        //    {
        //        for (int j = i + 1; j < numbers.Count; j++)
        //        {
        //            if (numbers[i] > numbers[j])
        //            {
        //                int temp = numbers[i];
        //                numbers[i] = numbers[j];
        //                numbers[j] = temp;
        //            }
        //        }
        //    }
        //}

        //static void Introduce()
        //{
        //    Console.WriteLine("My name is Kolio");
        //}

        //static void InvokeMethod(Action method)
        //{
        //    method.Invoke(); //= method();
        //}
        
        static void InvokeMethod2(Func<int,int,string> method, int number1, int number2)
        {
            var methodCallResult = method.Invoke(number1, number2);
            Console.WriteLine(methodCallResult);
        }
        static string AddNumbersAndReturnResultAsString(int number1, int number2)
        {
            return (number1 + number2).ToString();
        }
    }

    class Human
    {
        public static void Walk()
        {

        }
    }
}
