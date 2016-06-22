using MyClasses;
using MyExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods_Delegates_Lambda_LINKQ.Tests
{
    public static class StudentsTest
    {
        public static void Test()
        {

            var students = new Student[]
                {
                new Student("Gosho","Ivanov",15),
                new Student("Ivan","Georgiev",20),
                new Student("Boris","Petkanov",18),
                new Student("Ivan","Ivanovski",24),
                new Student("Boris","Borisov",35)
                };

            var reorderedStudentsbyName = students.FirstNameBeforeLastName();
            Console.WriteLine("--- Students Test ---");
            Console.WriteLine("Students with First Name before Last Name (Alphabetically)");
            foreach (var item in reorderedStudentsbyName)
            {
                Console.WriteLine(item);
            }
            var reorderedStudentsbyAge = students.AgeBetween18and24();
            Console.WriteLine();
            Console.WriteLine("Students between 18 and 24 years old");
            foreach (var item in reorderedStudentsbyAge)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Sorting students by First Name and Last Name in descending order");
            var reorderedDescending = students
                                    .OrderByDescending(x => x.FirstName)
                                    .ThenByDescending(x => x.LastName)
                                    .ToArray();
            foreach (var item in reorderedDescending)
            {
                Console.WriteLine(item);
            }
        }

        public static Group mathGroup = new Group(1,"Mathematics");
        public static Group scienceGroup = new Group(2,"Science");
        public static Group historyGroup = new Group(3,"History");
        public static Student[] students = new Student[]
               {
                new Student("Gosho", "Ivanov", 15, "IWERSF-20W2306", "(02) 12 34 56", "student1@yahoo.com", new List<int> { 4 ,6 },scienceGroup),
                new Student("Ivan","Georgiev",20, "ABCEDE-QW0052", "(25) 12 34 57", "student2@telerik.com", new List<int> {3 , 3 ,3 }, mathGroup),
                new Student("Boris","Petkanov",18, "DFE-20005", "(15) 12 34 58", "student3@abv.bg", new List<int> { 5 ,6 }, scienceGroup),
                new Student("Ivan","Ivanovski",24, "B-0054", "(11) 12 34 59", "student4@telerik.com", new List<int> {6 , 4 , 6, 2, 5, 6 }, historyGroup),
                new Student("Boris","Borisov",35, "A-WR1206", "(02) 12 34 60", "student5@telerik.com", new List<int> {2 ,2 }, mathGroup)
               };
        public static void TestTask9and10()
        {


            var group2Students = students.Where(x => x.Group.GroupNumber == 2);
            group2Students = group2Students.OrderBy(x => x.FirstName);

            Console.WriteLine("--- Taks 9,10 test ---");
            Console.WriteLine("Select only the students that are from group number 2. Ordered  by FirstName");
            foreach (var item in group2Students)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        public static void TestTaks11()
        {
            Console.WriteLine("--- Taks 11 test ---");
            var orderByEmailStudents = students.Where(x => x.Email.IndexOf("abv.bg") != -1);
            Console.WriteLine("Students with email in abv.bg");
            foreach (var item in orderByEmailStudents)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        public static void TestTask12()
        {
            Console.WriteLine("--- Taks 12 test ---");
            var orderByPhoneSofia = students.Where(x => x.Tel.IndexOf("(02)") != -1);
            Console.WriteLine("Students with phones in Sofia");
            foreach (var item in orderByPhoneSofia)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        public static void TestTask13()
        {
            //Anonymous Students
            var AnonymousStudents = new[] {
                new { FullName = "Pesho Ivanov", Marks = new[]{ 2, 2, 3, 4, 6} },
                new { FullName = "Gosho Petkov", Marks = new[] { 5, 5, 5, 4, 5 } },
                new { FullName = "Kiro Sekirata", Marks = new[] { 5, 6, 6, 4, 5 } },
                new { FullName = "Niki Mesoto", Marks = new[] { 2, 3, 3, 4, 5 } },
                new { FullName = "Vladimir Putin", Marks = new[] { 4, 5, 5, 4, 5 } },
                new { FullName = "Obama Asenov", Marks = new[] { 5, 5, 5, 4, 6 } }
            };
 
            Console.WriteLine("--- Taks 13 test ---");
            var mark6Students = students.Where(x => x.Marks.Contains(6));
            foreach (var item in mark6Students)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        public static void TestTask14()
        {
            Console.WriteLine("--- Taks 14 test ---");
            var studentsWith2Marks = students.Where(x => x.Marks.Count == 2);
            foreach (var item in studentsWith2Marks)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        public static void TestTask15()
        {
            Console.WriteLine("--- Taks 15 test ---");
            var studentsOf2006 = students.Where(x => x.FN.Substring(x.FN.Length - 2, 2) == "06");
            foreach (var item in studentsOf2006)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        public static void TestTask16()
        {
            Console.WriteLine("--- Taks 16 test ---");
            Group[] groups = { mathGroup };

            //students.Join<string, string, string, Student[]>(groups,)
            var result = from s in students
                         join g in groups on s.Group equals g
                         select s;
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        public static void TestTask18()
        {
            var group =
                from student in students
                group student by student.Group.GroupNumber into newGroup
                orderby newGroup.Key
                select newGroup;
            foreach (var nameGroup in group)
            {
                Console.WriteLine("Group: {0}", nameGroup.Key);
                foreach (var student in nameGroup)
                {
                    Console.WriteLine("\t{0}, {1}", student.FirstName, student.LastName);
                }
            }
        }
    }
}

