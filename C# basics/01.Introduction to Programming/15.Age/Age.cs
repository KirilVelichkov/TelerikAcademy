using System;

class Age
{
    static void Main(string[] args)
    {
        DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());
        DateTime dateToday = DateTime.Now;
        int age = dateToday.Year - dateOfBirth.Year;

        if (dateToday.Month < dateOfBirth.Month || (dateToday.Month == dateOfBirth.Month && dateToday.Day < dateOfBirth.Day))
        {
            age--;
        }

        Console.WriteLine(age);
        Console.WriteLine(age + 10);

    }
}

