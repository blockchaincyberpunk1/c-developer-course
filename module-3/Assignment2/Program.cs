using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create students, courses, and enrollments
        var student1 = new Student { StudentID = 1, FirstName = "Alice", LastName = "Johnson", DateOfBirth = new DateTime(1990, 5, 15) };
        var student2 = new Student { StudentID = 2, FirstName = "Bob", LastName = "Smith", DateOfBirth = new DateTime(1992, 8, 22) };

        var course1 = new Course { CourseID = 101, CourseName = "Mathematics", Instructor = "Dr. Johnson", Credits = 3 };
        var course2 = new Course { CourseID = 102, CourseName = "Computer Science", Instructor = "Prof. Smith", Credits = 4 };

        var enrollment1 = new Enrollment { EnrollmentID = 1, Student = student1, Course = course1, EnrollmentDate = DateTime.Now, Grade = "A" };
        var enrollment2 = new Enrollment { EnrollmentID = 2, Student = student2, Course = course2, EnrollmentDate = DateTime.Now, Grade = "B" };

        // Simulate SIS operations
        student1.RegisterForCourse(course2);
        course1.AddEnrollment(enrollment1);

        // Display student and course information
        Console.WriteLine($"Student: {student1.FirstName} {student1.LastName}");
        Console.WriteLine($"Course: {course2.CourseName}, Credits: {course2.Credits}");
    }
}
