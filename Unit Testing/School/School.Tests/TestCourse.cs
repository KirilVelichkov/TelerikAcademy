using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace School.Tests
{
    [TestClass]
    public class TestCourse
    {

        [TestInitialize]
        public void CourseShouldNotThrowExceptionWhenCreatingNewCourse()
        {
            var course = new Course("course1");
        }

        [TestMethod]
        public void CourseShouldReturnCorrectCourseName()
        {
            // Arrange
            var course = new Course("course1");

            // Act
            var expectedResult = "course1";
            var result = course.Name;

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CourseShouldThrowExceptionWhenAddingNullStudent()
        {
            var course = new Course("course1");
            course.AddStudent(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CourseShouldThrowExceptionWhenAddingStudent_ThatAlreadyExists()
        {
            var course = new Course("course1");
            var student = new Student("student1", 10000);

            course.AddStudent(student);
            course.AddStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CourseShouldThrowExceptionWhenAddingStudent_WithTheSameID()
        {
            var course = new Course("course1");
            var student1 = new Student("student1", 10000);
            var student2 = new Student("student2", 10000);

            course.AddStudent(student1);
            course.AddStudent(student2);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CourseShouldThrowExceptionWhenAddingStudent_ToAFullCourse()
        {
            var course = new Course("course1");
            for (int i = 0; i < 50; i++)
            {
                course.AddStudent(new Student(i.ToString(), 10000 + i));
            }
        }

        [TestMethod]
        public void CourseShouldAddStudentCorrectly()
        {
            var course = new Course("course1");
            var student = new Student("student1", 10000);

            course.AddStudent(student);

            Assert.AreSame(student, course.Students.First());
        }

        [TestMethod]
        public void CourseShouldRemoveStudentCorrectly()
        {
            var course = new Course("course1");
            var student = new Student("student1", 10000);

            course.AddStudent(student);
            course.RemoveStudent(student);

            Assert.IsFalse(course.Students.Contains(student));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CourseShouldThrowExceptionWhenRemovingNullStudent()
        {
            var course = new Course("course1");
            course.RemoveStudent(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CourseShouldThrowExceptionWhenRemovingStudent_ThatDoesNotExist()
        {
            var course = new Course("course1");
            var student = new Student("student1", 10000);
            course.RemoveStudent(student);
        }
    }
}
