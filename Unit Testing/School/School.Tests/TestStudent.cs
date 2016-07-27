using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

namespace School.Tests
{
    [TestClass]
    public class TestStudent
    {
        [TestMethod]
        public void StudentShouldNotThrowExceptionWhenCreatingNewStudent()
        {
            // Arrange
            var student = new Student("Student1", 10000);

        }

        [TestMethod]
        public void StudentShouldReturnCorrectName()
        {
            // Arrange
            var student = new Student("Student1", 10000);

            // Act
            var expectedResult = "Student1";
            var result = student.Name;

            // Assert
            Assert.AreEqual(expectedResult, result);

        }

        [TestMethod]
        public void StudentShouldReturnCorrectID()
        {
            // Arrange
            var student = new Student("Student1", 10000);

            // Act
            var expectedResult = 10000;
            var result = student.ID;

            // Assert
            Assert.AreEqual(expectedResult, result);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StudentShouldThrowException_IfStudentNameIsNull()
        {
            var student = new Student(null, 10000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StudentShouldThrowException_IfStudentNameIsEmpty()
        {
            var student = new Student(string.Empty, 10000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StudentShouldThrowException_IfMinStudID_IsNotValid()
        {
            var student = new Student("stud1", 9999);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StudentShouldThrowException_IfMaxStudID_IsNotValid()
        {
            var student = new Student("stud1", 100000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StudentShouldThrowException_WhenAttendingNullCourse()
        {
            var student = new Student("stud1", 10000);
            Course course = null;
            student.AttendCourse(course);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StudentShouldThrowException_WhenLeavingNullCourse()
        {
            var student = new Student("stud1", 10000);
            Course course = null;
            student.LeaveCourse(course);
        }
    }
}
