using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter their age
        Console.Write("Please enter your age: ");
        
        // Read user input and parse it to an integer
        if (int.TryParse(Console.ReadLine(), out int age))
        {
            // Use an if-else statement to make a decision based on age
            if (age < 18)
            {
                Console.WriteLine("You are a minor.");
            }
            else if (age >= 18 && age <= 65)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are a senior citizen.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid age.");
        }
    }
}

/*  
We start by importing the System namespace for input and output operations.
In the Main method, we prompt the user to enter their age using Console.Write and then read their input using Console.ReadLine().
We use int.TryParse to parse the user's input into an integer (age).
Next, we use an if-else statement to make decisions based on the user's age:
If the age is less than 18, we display "You are a minor."
If the age is between 18 and 65 (inclusive), we display "You are an adult."
If the age is greater than or equal to 65, we display "You are a senior citizen."
If the input is not a valid integer, we display an error message.
*/
