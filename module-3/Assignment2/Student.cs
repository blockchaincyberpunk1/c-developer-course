using System;
using System.Collections.Generic;

public class Student
{
    public int StudentID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public List<Enrollment> Enrollments { get; set; }

    public void RegisterForCourse(Course course)
    {
        // Implementation to register the student for a course
    }
}
