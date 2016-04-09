using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
A marketing company wants to keep record of its employees. Each record would have the following characteristics:

    First name
    Last name
    Age (0...100)
    Gender (m or f)
    Personal ID number (e.g. 8 306 112 507)
    Unique employee number (27560000…27569999)

Declare the variables needed to keep the information for a single employee using appropriate primitive data types.
Use descriptive names. Print the data at the console.

*/

class Employees
{
    static void Main(string[] args)
    {
        string FirstName = "Kiril";
        string LastName = "Velichkow";
        int Age = 28;
        string Gender = "m";
        ulong ID_Number = 8306112507;
        ulong Employee_N = 275623499;

        Console.WriteLine(@"First Name: {0}
Last Name: {1}
Age: {2}
Gender: {3}
Personal ID number: {4}
Unique employee number: {5}", FirstName, LastName, Age, Gender, ID_Number, Employee_N);
    }
}

