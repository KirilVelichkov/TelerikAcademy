using Extension_Methods_Delegates_Lambda_LINKQ.Tests;
using MyClasses;
using MyExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading;

namespace Extension_Methods_Delegates_Lambda_LINKQ
{
    class StartUp
    {
        static void Main()
        {


            //Task 1
            //StringBuilderTest.Test();

            //Task 2
            //IEnumerableTest.Test();

            //Tasks 3,4,5
            //StudentsTest.Test();

            //Task 6
            //DivisibleBy7and3Test.Test();

            //Task 7
            //MyClasses.Timer timer = new MyClasses.Timer(Task7Test,3);
            //timer.Stop();

            //MyClasses.Timer timer = new MyClasses.Timer(Task7Test,3,5);

            //Task 8
            //It says "click", because i have re-created the JavaScript click event
            //MyClasses.EventHandler MyEvent = new MyClasses.EventHandler();
            //MyEvent.On("click", Task8Test);
            //MyEvent.Trigger("click");

            //Subscriber sub = new Subscriber();
            //sub.On("Print", Task8Test2);
            //sub.Print("Print");

            //Task 9,10
            //StudentsTest.TestTask9and10();

            //Task 11
            //StudentsTest.TestTaks11();

            //Task 12
            //StudentsTest.TestTask12();

            //Task 13
            //StudentsTest.TestTask13();

            //Task 14
            //StudentsTest.TestTask14();

            //Task 15
            //StudentsTest.TestTask15();

            //Task 16
            //StudentsTest.TestTask16();

            //Task 17
            //TestTask17();

            //Task 18
            //StudentsTest.TestTask18();

            //Task 19
            //StudentsTest.students.GroupedByGroupNumber();

            //Task 20
            //NOTE: Second param is the precision you want(defaul is 2 like requested in the homework)
            //Console.WriteLine(InfinteCalculate1(inf1,2));
            //Console.WriteLine(InfinteCalculate2(inf2, 2));
            //Console.WriteLine(InfinteCalculate3(inf1, 2));

        }
        public delegate double InfDelegate(double i);

        public static double InfinteCalculate1(InfDelegate method, int pr = 2, double i = 1)
        {
            double t = 1 / i;

            if (t.ToString().Length > 2 + pr) return double.Parse(t.ToString("F" + pr));
            return t + InfinteCalculate1(method, pr, method(i));
        }

        public static double InfinteCalculate2(InfDelegate method, int pr = 2, double i = 1)
        {
            double t = 1 / i;
            if (t.ToString().Length > 2 + pr) return double.Parse(t.ToString("F" + pr));
            return t + InfinteCalculate2(method, pr, FactCalc(method(i)));
        }

        public static double InfinteCalculate3(InfDelegate method, int pr = 2, double i = 1)
        {
            double t = 1 / i;
            if (t.ToString().Length > 2 + pr) return double.Parse(t.ToString("F" + pr));
            return t + (InfinteCalculate3(method, pr, method(i)) - InfinteCalculate3(method, pr, method(i)*2));
        }

        public static double inf1(double i)
        {
            return i * 2;
        }

        public static double inf2(double i)
        {
            return i + 1;
        }

        public static double FactCalc(double i)
        {
            double sum = 1;

            for (int j = 1; j <= i; j++)
            {
                sum *= j;
            }
            return sum;
        }

        public static void TestTask17()
        {
            Console.Write("Enter array size: ");
            var arrSize = int.Parse(Console.ReadLine());
            var arr = new List<string>();
            string str = string.Empty;
            for (int i = 0; i < arrSize; i++)
            {
                Console.Write($"Enter string {i + 1}:");
                arr.Add(Console.ReadLine());
            }

            Console.WriteLine($"Longets string is: {arr.OrderByDescending(s => s.Length).First()}");

        }

        public static void Task7Test()
        {
            Console.WriteLine("Task7Test Method");
        } 

        public static void Task8Test(Array args)
        {
            int[] arr = (int[])args;
            Console.WriteLine("Task8Test Method");
        }

        public static void Task8Test2(Array args)
        {
            Console.WriteLine("print event handled");
        }

    }
   
}
