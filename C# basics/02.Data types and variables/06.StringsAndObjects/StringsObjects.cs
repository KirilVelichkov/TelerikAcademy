﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Declare two string variables and assign them with Hello and World.
Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between). 
Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).
*/

class StringsObjects
{
    static void Main(string[] args)
    {
        string string1 = "Hello";
        string string2 = "Worlds";
        object @object = string1 + " " + string2;
        string string3 = (string)@object;
        Console.WriteLine(string3);
    }
}

