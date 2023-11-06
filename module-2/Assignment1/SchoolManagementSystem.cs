using System;
using System.Collections.Generic;

// Base class representing a Person
class Person
{
    public int PersonId { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime DateOfBirth { get; set; }

    public Person(int personId, string name, string address, string phoneNumber, DateTime dateOfBirth)
    {
        PersonId = personId;
        Name = name;
        Address = address;
        PhoneNumber = phoneNumber;
        DateOfBirth = dateOfBirth;
    }
}

// Derived class representing a Teacher
class Teacher : Person
{
    public string Department { get; set; }
    public List<Course> Courses { get; set; }

    public Teacher(int teacherId, string name, string address, string phoneNumber, DateTime dateOfBirth, string department)
        : base(teacherId, name, address, phoneNumber, dateOfBirth)
    {
        Department = department;
        Courses = new List<Course>();
    }

    public void AssignAssignment(Course course, Assignment assignment)
    {
        // Implement assignment assignment logic here
    }

    public void AssignExam(Course course, Exam exam)
    {
        // Implement exam assignment logic here
    }
}

// Derived class representing a Student
class Student : Person
{
    public List<Course> Courses { get; set; }
    public List<Grade> Grades { get; set; }

    public Student(int studentId, string name, string address, string phoneNumber, DateTime dateOfBirth)
        : base(studentId, name, address, phoneNumber, dateOfBirth)
    {
        Courses = new List<Course>();
        Grades = new List<Grade>();
    }

    public void EnrollInCourse(Course course)
    {
        Courses.Add(course);
    }

    public void ReceiveGrade(Grade grade)
    {
        Grades.Add(grade);
    }
}

// Class representing a Course
class Course
{
    public int CourseId { get; set; }
    public string Name { get; set; }
    public Teacher Teacher { get; set; }
    public List<Student> Students { get; set; }
    public List<Assignment> Assignments { get; set; }
    public List<Exam> Exams { get; set; }

    public Course(int courseId, string name, Teacher teacher)
    {
        CourseId = courseId;
        Name = name;
        Teacher = teacher;
        Students = new List<Student>();
        Assignments = new List<Assignment>();
        Exams = new List<Exam>();
    }

    public void AddStudent(Student student)
    {
        Students.Add(student);
    }

    public void AddAssignment(Assignment assignment)
    {
        Assignments.Add(assignment);
    }

    public void AddExam(Exam exam)
    {
        Exams.Add(exam);
    }
}

// Class representing an Assignment
class Assignment
{
    public int AssignmentId { get; set; }
    public string Title { get; set; }
    public Course Course { get; set; }

    public Assignment(int assignmentId, string title, Course course)
    {
        AssignmentId = assignmentId;
        Title = title;
        Course = course;
    }
}

// Class representing an Exam
class Exam
{
    public int ExamId { get; set; }
    public string Title { get; set; }
    public Course Course { get; set; }

    public Exam(int examId, string title, Course course)
    {
        ExamId = examId;
        Title = title;
        Course = course;
    }
}

// Class representing a Grade
class Grade
{
    public int GradeId { get; set; }
    public Student Student { get; set; }
    public Course Course { get; set; }
    public double Value { get; set; }

    public Grade(int gradeId, Student student, Course course, double value)
    {
        GradeId = gradeId;
        Student = student;
        Course = course;
        Value = value;
    }
}

class Program
{
    static void Main()
    {
        // Create instances of Teacher, Student, Course, Assignment, Exam, and Grade
        Teacher teacher1 = new Teacher(1, "Teacher1", "Address1", "123-456-7890", new DateTime(1980, 1, 15), "Mathematics");
        Student student1 = new Student(1, "Student1", "Address2", "555-123-4567", new DateTime(1995, 3, 20));
        Course course1 = new Course(1, "Math101", teacher1);
        Assignment assignment1 = new Assignment(1, "Assignment 1", course1);
        Exam exam1 = new Exam(1, "Midterm Exam", course1);
        Grade grade1 = new Grade(1, student1, course1, 90.5);

        // Perform actions (e.g., enroll student, assign assignment, record grade)
        student1.EnrollInCourse(course1);
        teacher1.AssignAssignment(course1, assignment1);
        student1.ReceiveGrade(grade1);

        // Display information
        Console.WriteLine("Teacher: " + teacher1.Name);
        Console.WriteLine("Student: " + student1.Name);
        Console.WriteLine("Course: " + course1.Name);
        Console.WriteLine("Assignment: " + assignment1.Title);
        Console.WriteLine("Grade: " + grade1.Value);
    }
}
