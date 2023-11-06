using System;

class Program
{
    static void Main(string[] args)
    {
        // Example 1: Division by Zero Exception
        int numerator = 10;
        int denominator = 0;
        try
        {
            int result = numerator / denominator; // Attempting division by zero
            Console.WriteLine("Result of division: " + result);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        // Example 2: Null Reference Exception
        string text = null;
        try
        {
            int length = text.Length; // Attempting to access length of null reference
            Console.WriteLine("Length of text: " + length);
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        // Other examples...

        Console.WriteLine("Program continues execution...");
    }
}

/* 
In this program:

I intentionally create two scenarios to generate exceptions: division by zero and accessing the length property of a null reference string.

I use try-catch blocks to catch and handle these exceptions. If an exception occurs, the catch block is executed, and we print an error message along with the exception's message.

After handling the exceptions, the program continues its execution, demonstrating that it doesn't crash due to the exceptions.
*/

/*  
Exceptions are runtime errors that can occur during the execution of a program when an unexpected situation or error condition is encountered. They are essential for robust error handling because they allow a program to gracefully respond to these errors instead of crashing or producing unpredictable results. Exceptions help in identifying and diagnosing issues, making it easier to fix problems in the code.

Common scenarios where exceptions commonly occur include:

1. Division by Zero: When attempting to divide a number by zero.

2. Null Reference: Trying to access properties, methods, or fields of an object that is null.

3. File I/O: Reading from or writing to files that do not exist or are not accessible.

4. Network Errors: When network operations fail due to connectivity issues or other problems.

5. Invalid Input: Handling invalid user input or data that doesn't conform to expected formats.
*/
