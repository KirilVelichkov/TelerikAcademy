using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClasses;
using System.Collections;

namespace MyExtensions
{
    public static class StudentCollectionExtensions
    {
        public static Student[] FirstNameBeforeLastName(this Student[] students)
        {
            var result = students.Where(x => (x.FirstName).CompareTo(x.LastName) < 0).ToArray();
            return result;
        }

        public static Student[] AgeBetween18and24(this Student[] students)
        {
            var result = students.Where(x => x.Age >= 18 && x.Age <= 24).ToArray();
            return result;
        }

        public static void GroupedByGroupNumber(this Student[] students)
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
