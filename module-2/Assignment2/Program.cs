using System;

class Program
{
    static void Main()
    {
        // Create a Student object
        Student student1 = new Student("Alice", 20, 3.5);

        // Access properties and call methods
        Console.WriteLine("Initial Student Details:");
        Console.WriteLine(student1.GetDetails());

        // Update GPA
        Console.WriteLine("\nUpdating GPA...");
        student1.UpdateGPA(3.8);
        Console.WriteLine(student1.GetDetails());

        // Celebrate birthday
        Console.WriteLine("\nCelebrating Birthday...");
        student1.CelebrateBirthday();
        Console.WriteLine(student1.GetDetails());

        // Create additional Student objects and demonstrate functionality
        // ...

        Console.ReadKey(); // Keep the console window open
    }
}
