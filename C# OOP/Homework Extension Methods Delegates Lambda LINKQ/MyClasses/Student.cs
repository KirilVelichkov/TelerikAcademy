using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
    public class Student
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public string FN { get; private set; }
        public string Tel { get; private set; }
        public string Email { get; private set; }
        public List<int> Marks { get; set; }
        public Group Group { get; private set; }

        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
        public Student(string firstName, string lastName, int age, string fn, string tel, string email, List<int> marks, Group group) 
            :this(firstName,  lastName,  age)
        {
            this.FN = fn;
            this.Tel = tel;
            this.Email = email;
            this.Marks = marks;
            this.Group = group;
        }
        public override string ToString()
        {
            var result = new StringBuilder();
            var marks = new StringBuilder();
            foreach (var item in this.Marks)
            {
                marks.Append(item + " ");
            }
            result.Append($"First Name: {this.FirstName}").Append("\n\r");
            result.Append($"Last Name: {this.LastName}").Append("\n\r");
            result.Append($"Age: {this.Age}").Append("\n\r");
            result.Append($"FN: {this.FN}").Append("\n\r");
            result.Append($"Tel: {this.Tel}").Append("\n\r");
            result.Append($"Email: {this.Email}").Append("\n\r");
            result.Append($"Mark: {marks}").Append("\n\r");
            result.Append($"Group Number({Group.GroupNumber}), Department: {Group.DepartmentName}").Append("\n\r");
            return result.ToString();
        }
    }
}
