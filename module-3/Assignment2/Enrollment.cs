using System;

public class Enrollment
{
    public int EnrollmentID { get; set; }
    public Student Student { get; set; }
    public Course Course { get; set; }
    public DateTime EnrollmentDate { get; set; }
    public string Grade { get; set; }
}
