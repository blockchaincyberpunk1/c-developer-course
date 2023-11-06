using System;
using System.Collections.Generic;

public class Course
{
    public int CourseID { get; set; }
    public string CourseName { get; set; }
    public string Instructor { get; set; }
    public int Credits { get; set; }
    public List<Enrollment> Enrollments { get; set; }

    public void AddEnrollment(Enrollment enrollment)
    {
        // Implementation to add an enrollment to the course
    }
}
