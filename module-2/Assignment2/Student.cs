using System;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double GPA { get; private set; }

    // Constructor
    public Student(string name, int age, double gpa)
    {
        Name = name;
        Age = age;
        GPA = gpa;
    }

    // Method to get student details
    public string GetDetails()
    {
        return $"Name: {Name}, Age: {Age}, GPA: {GPA:F2}";
    }

    // Method to update GPA
    public void UpdateGPA(double newGPA)
    {
        if (newGPA >= 0 && newGPA <= 4.0)
        {
            GPA = newGPA;
        }
        else
        {
            Console.WriteLine("Invalid GPA. GPA should be between 0 and 4.0.");
        }
    }

    // Method to celebrate the student's birthday
    public void CelebrateBirthday()
    {
        Age++;
    }
}
