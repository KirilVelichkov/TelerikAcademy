using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Course
    {
        private const int maxStudents = 30;

        private string name;
        private ICollection<Student> students;

        public Course(string name)
        {
            this.Name = name;
            this.students = new List<Student>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
           private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Course name", "Name cannot be null or empty!");
                }
                this.name = value;
            }
        }

        public ICollection<Student> Students {
            get
            {
                return new List<Student>(this.students);
            }
                }


        public void AddStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("student", "Student cannot be null.");
            }

            if (this.students.Contains(student))
            {
                throw new ArgumentException("Student", "Student already exist");
            }

            if (this.students.Any(x => x.ID == student.ID))
            {
                throw new ArgumentException("Student", "Student with this ID already exists");
            }

            if(this.students.Count >= maxStudents)
            {
                throw new InvalidOperationException("Students list is full");
            }
            this.students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Student", "Student cannot be null.");
            }

            if (!this.students.Contains(student))
            {
                throw new ArgumentException("Student", "Student doesnt exist");
            }

            this.students.Remove(student);
        }
    }
}
