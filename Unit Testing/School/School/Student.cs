using System;


namespace School
{
    public class Student
    {
        private const int minIdValue = 10000;
        private const int maxIdvalue = 99999;
        private const int maxStudents = 30;
        private int id;
        private string name;


        public Student(string name, int id)
        {
            this.Name = name;
            this.ID = id;
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
                    throw new ArgumentNullException("Student name", "Name cannot be null or empty!");
                }
                this.name = value;
            }
        }

        public int ID
        {
            get
            {
                return this.id;
            }
           private set
            {
                if (value < minIdValue || value > maxIdvalue)
                {
                    throw new ArgumentOutOfRangeException("Student ID", 
                            string.Format("Student ID must be in range {0} - {1}", minIdValue, maxIdvalue));
                }
                this.id = value;
            }
        }

        public void AttendCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("course", "Course cannot be null.");
            }

            if(course.Students.Count >= maxStudents)
            {
                throw new InvalidOperationException("Students list is full");
            }
            course.AddStudent(this);
        }

        public void LeaveCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("course", "Course cannot be null.");
            }

            course.RemoveStudent(this);
        }
    }
}

