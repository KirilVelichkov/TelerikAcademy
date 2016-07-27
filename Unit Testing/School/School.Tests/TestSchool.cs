using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace School.Tests
{
    [TestClass]
    public class TestSchool
    {
        [TestMethod]
        public void SchoolShouldNotThrowExceptionWhenCreatingNewSchool()
        {
            var school = new School("School1");
        }

        [TestMethod]
        public void SchoolShouldReturnNameCorrectly()
        {
            // Arrange
            var school = new School("School1");

            // Act
            var expectedResult = "School1";
            var result = school.Name;

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SchoolShouldThrowException_IfNameIsNull()
        {
            var school = new School(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SchoolShouldThrowException_IfNameIsEmpty()
        {
            var school = new School(string.Empty);
        }

        [TestMethod]
        public void SchoolShouldAddStudentCorrectly()
        {
            // Arrange
            var school = new School("school1");
            var student = new Student("stud1", 10000);

            // Act
            school.AddStudent(student);

            // Assert
            Assert.AreSame(student, school.Students.First());
        }

        [TestMethod]
        public void SchoolShouldRemoveStudentCorrectly()
        {
            // Arrange
            var school = new School("school1");
            var student = new Student("stud1", 10000);

            // Act
            school.AddStudent(student);
            school.RemoveStudent(student);

            // Assert
            Assert.IsFalse(school.Students.Contains(student));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SchoolShouldThrowExceptionIfNullStudentIsAdded()
        {
            // Arrange
            var school = new School("school1");

            // Act
            school.AddStudent(null);

        }

        [TestMethod]
        public void SchoolShouldAddCourseCorrectly()
        {
            // Arrange
            var school = new School("school1");
            var course = new Course("course1");

            // Act
            school.AddCourse(course);

            // Assert
            Assert.AreSame(course, school.Courses.First());
        }

        [TestMethod]
        public void SchoolShouldRemoveCourseCorrectly()
        {
            // Arrange
            var school = new School("school1");
            var course = new Course("course1");

            // Act
            school.AddCourse(course);
            school.RemoveCourse(course);

            // Assert
            Assert.IsFalse(school.Courses.Contains(course));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SchoolShouldThrowExceptionIfNullCourseIsAdded()
        {
            // Arrange
            var school = new School("school1");

            // Act
            school.AddCourse(null);

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void SchoolShouldThrowException_WhenCourseThatAlreadyExists_IsAdded()
        {
            // Arrange
            var school = new School("school1");
            var course1 = new Course("course1");
            // Act
            school.AddCourse(course1);
            school.AddCourse(course1);

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void SchoolShouldThrowException_WhenStudentThatAlreadyExists_IsAdded()
        {
            // Arrange
            var school = new School("school1");
            var student = new Student("student1", 10000);
            // Act
            school.AddStudent(student);
            school.AddStudent(student);

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void SchoolShouldThrowException_WhenStudentWithSameID_IsAdded()
        {
            // Arrange
            var school = new School("school1");
            var student1 = new Student("student1", 10000);
            var student2 = new Student("student2", 10000);
            // Act
            school.AddStudent(student1);
            school.AddStudent(student2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SchoolShouldThrowException_WhenRemovingNullCourse()
        {
            // Arrange
            var school = new School("school1");
            // Act
            school.RemoveCourse(null);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SchoolShouldThrowException_WhenRemovingNullStudent()
        {
            // Arrange
            var school = new School("school1");
            // Act
            school.RemoveStudent(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SchoolShouldThrowException_WhenRemovingStudent_ThatDeosNotExist()
        {
            // Arrange
            var school = new School("school1");
            var student = new Student("stud1", 10000);
            // Act
            school.RemoveStudent(student);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SchoolShouldThrowException_WhenRemovingCourse_ThatDeosNotExist()
        {
            // Arrange
            var school = new School("school1");
            var course = new Course("course1");
            // Act
            school.RemoveCourse(course);
        }
    }
}
