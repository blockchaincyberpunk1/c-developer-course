using System;

class Program
{
    static void Main()
    {
        // Display a welcome message
        Console.WriteLine("Welcome to the Simple Calculator!");
        Console.WriteLine("Please select an operation:");
        Console.WriteLine("1. Addition (+)");
        Console.WriteLine("2. Subtraction (-)");
        Console.WriteLine("3. Multiplication (*)");
        Console.WriteLine("4. Division (/)");

        // Prompt the user to select an operation
        Console.Write("Enter the number corresponding to your choice: ");
        int choice;
        if (int.TryParse(Console.ReadLine(), out choice))
        {
            double result = 0; // Initialize the result variable

            // Check the selected operation
            switch (choice)
            {
                case 1: // Addition
                    result = PerformAddition();
                    break;
                case 2: // Subtraction
                    result = PerformSubtraction();
                    break;
                case 3: // Multiplication
                    result = PerformMultiplication();
                    break;
                case 4: // Division
                    result = PerformDivision();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid operation (1-4).");
                    break;
            }

            // Display the result
            Console.WriteLine("Result: " + result);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid choice (1-4).");
        }
    }

    static double GetNumberFromUser(string prompt)
    {
        double number;
        bool isValidInput;

        do
        {
            Console.Write(prompt);
            isValidInput = double.TryParse(Console.ReadLine(), out number);

            if (!isValidInput)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        } while (!isValidInput);

        return number;
    }

    static double PerformAddition()
    {
        double num1 = GetNumberFromUser("Enter the first number: ");
        double num2 = GetNumberFromUser("Enter the second number: ");
        return num1 + num2;
    }

    static double PerformSubtraction()
    {
        double num1 = GetNumberFromUser("Enter the first number: ");
        double num2 = GetNumberFromUser("Enter the second number: ");
        return num1 - num2;
    }

    static double PerformMultiplication()
    {
        double num1 = GetNumberFromUser("Enter the first number: ");
        double num2 = GetNumberFromUser("Enter the second number: ");
        return num1 * num2;
    }

    static double PerformDivision()
    {
        double num1 = GetNumberFromUser("Enter the dividend: ");
        double num2;
        do
        {
            num2 = GetNumberFromUser("Enter the divisor (non-zero): ");
            if (num2 == 0)
            {
                Console.WriteLine("Division by zero is not allowed. Please enter a non-zero divisor.");
            }
        } while (num2 == 0);

        return num1 / num2;
    }
}

/*  
Start by displaying a welcome message and a menu of arithmetic operations (addition, subtraction, multiplication, division) for the user to choose from.

Prompt the user to enter their choice (1, 2, 3, or 4) corresponding to the desired operation.

Depending on the user's choice, we call the respective operation function (e.g., PerformAddition, PerformSubtraction, etc.), which takes user input for operands and performs the operation.

The GetNumberFromUser function is used to handle user input for numbers, ensuring that valid numeric values are entered.

Display the result of the operation to the user.

Proper error handling is implemented to handle cases such as invalid input and division by zero.

*/
