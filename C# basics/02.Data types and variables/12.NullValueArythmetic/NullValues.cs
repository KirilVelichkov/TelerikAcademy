using System;
/*
Problem 13.	Null Values Arithmetic
Create a program that assigns null values to an integer and to a double variable. 
Try to print these variables at the console. Try to add some number or the null literal to these variables 
and print the result.
*/
class NullArithmetic
{
    static void Main()
    {
        int? _Integer = null;
        double? _Double = null;

        Console.WriteLine("This is an integer variable with value - {0}", _Integer);
        _Integer += 10;
        Console.WriteLine("This is an integer variable with value - {0}", _Integer);
        Console.WriteLine("This is a Double variable with value - {0}", _Double);
        _Double = 20;
        Console.WriteLine("This is a Double variable with value - {0}", _Double);
    }
}

