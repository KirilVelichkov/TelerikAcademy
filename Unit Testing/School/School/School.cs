using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class School
    {

        private string name;
        private ICollection<Student> students;
        private ICollection<Course> courses;

        public int MyProperty { get; set; }

        public School(string name)
        {
            this.Name = name;
            this.students = new List<Student>();
            this.courses = new List<Course>();
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
                    throw new ArgumentNullException("School name", "Name cannot be null or empty!");
                }
                this.name = value;
            }
        }

        public ICollection<Course> Courses
        {
            get
            {
                return new List<Course>(this.courses);
            }
        }

        public ICollection<Student> Students
        {
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
                throw new InvalidOperationException("Student already exist");
            }

            if (this.students.Any(x => x.ID == student.ID))
            {
                throw new InvalidOperationException("Student with this ID already exists");
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
                throw new ArgumentException("Student", "Student desnt exist");
            }

            this.students.Remove(student);
        }

        public void AddCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("Course", "Course cannot be null");
            }

            if (this.courses.Contains(course))
            {
                throw new InvalidOperationException("Course already exists!");
            }

            this.courses.Add(course);
        }

        public void RemoveCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("Course", "Course cannot be null");
            }

            if (!this.courses.Contains(course))
            {
                throw new ArgumentException("Course", "Course doesnt exists!");
            }

            this.courses.Remove(course);
        }
    }
}
