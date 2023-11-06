using System;
using System.Collections.Generic;

// Base class representing a course
class Course
{
    public int CourseId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public List<Lecture> Lectures { get; set; }
    public List<Quiz> Quizzes { get; set; }

    public Course(int courseId, string title, string description)
    {
        CourseId = courseId;
        Title = title;
        Description = description;
        Lectures = new List<Lecture>();
        Quizzes = new List<Quiz>();
    }

    public void AddLecture(Lecture lecture)
    {
        Lectures.Add(lecture);
    }

    public void AddQuiz(Quiz quiz)
    {
        Quizzes.Add(quiz);
    }
}

// Instructor class
class Instructor
{
    public int InstructorId { get; set; }
    public string Name { get; set; }

    public Instructor(int instructorId, string name)
    {
        InstructorId = instructorId;
        Name = name;
    }

    public void TeachCourse(Course course)
    {
        Console.WriteLine($"{Name} is teaching the course '{course.Title}'.");
    }
}

// Student class
class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    public List<Assignment> Assignments { get; set; }
    public List<Quiz> CompletedQuizzes { get; set; }
    public List<Course> EnrolledCourses { get; set; }

    public Student(int studentId, string name)
    {
        StudentId = studentId;
        Name = name;
        Assignments = new List<Assignment>();
        CompletedQuizzes = new List<Quiz>();
        EnrolledCourses = new List<Course>();
    }

    public void EnrollInCourse(Course course)
    {
        EnrolledCourses.Add(course);
        Console.WriteLine($"{Name} has enrolled in the course '{course.Title}'.");
    }

    public void SubmitAssignment(Assignment assignment)
    {
        Assignments.Add(assignment);
        Console.WriteLine($"{Name} has submitted an assignment for '{assignment.Course.Title}'.");
    }

    public void TakeQuiz(Quiz quiz)
    {
        CompletedQuizzes.Add(quiz);
        Console.WriteLine($"{Name} has completed a quiz for '{quiz.Course.Title}'.");
    }
}

// Assignment class
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

// Lecture class
class Lecture
{
    public int LectureId { get; set; }
    public string Title { get; set; }
    public Course Course { get; set; }

    public Lecture(int lectureId, string title, Course course)
    {
        LectureId = lectureId;
        Title = title;
        Course = course;
    }
}

// Quiz class
class Quiz
{
    public int QuizId { get; set; }
    public string Title { get; set; }
    public Course Course { get; set; }

    public Quiz(int quizId, string title, Course course)
    {
        QuizId = quizId;
        Title = title;
        Course = course;
    }
}

// Certificate class
class Certificate
{
    public int CertificateId { get; set; }
    public string Title { get; set; }
    public Student Student { get; set; }

    public Certificate(int certificateId, string title, Student student)
    {
        CertificateId = certificateId;
        Title = title;
        Student = student;
    }
}

class Program
{
    static void Main()
    {
        // Create instances of Course, Instructor, and Student
        Course course1 = new Course(1, "Programming Basics", "Introduction to Programming");
        Instructor instructor1 = new Instructor(101, "John Instructor");
        Student student1 = new Student(201, "Alice Student");

        // Enroll the student in the course
        student1.EnrollInCourse(course1);

        // Assign an instructor to the course
        instructor1.TeachCourse(course1);

        // Create instances of Assignment, Lecture, Quiz, and Certificate
        Assignment assignment1 = new Assignment(301, "Assignment 1", course1);
        Lecture lecture1 = new Lecture(401, "Introduction to C#", course1);
        Quiz quiz1 = new Quiz(501, "Quiz 1", course1);
        Certificate certificate1 = new Certificate(601, "C# Programming Basics Certificate", student1);

        // Student submits an assignment and takes a quiz
        student1.SubmitAssignment(assignment1);
        student1.TakeQuiz(quiz1);

        // Display the student's earned certificate
        Console.WriteLine($"{student1.Name} has earned the '{certificate1.Title}'!");

        // Additional actions and interactions can be added as needed for the scenario
    }
}



// Output:
// Alice Student has earned the 'C# Programming Basics Certificate'!

// Additional interactions can be added as needed for the scenario.

// Instructor John Instructor teaches the course 'Programming Basics'.
// Alice Student has enrolled in the course 'Programming Basics'.
// Alice Student has submitted an assignment for 'Programming Basics'.
// Alice Student has completed a quiz for 'Programming Basics'.
// Alice Student has earned the 'C# Programming Basics Certificate'!

// Additional interactions can be added as needed for the scenario.

// Instructor John Instructor teaches the course 'Programming Basics'.
// Alice Student has enrolled in the course 'Programming Basics'.
// Alice Student has submitted an assignment for 'Programming Basics'.
// Alice Student has completed a quiz for 'Programming Basics'.
// Alice Student has earned the 'C# Programming Basics Certificate'!

// Additional interactions can be added as needed for the scenario.

// Instructor John Instructor teaches the course 'Programming Basics'.
