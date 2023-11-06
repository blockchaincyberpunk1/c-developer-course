using System;  // This is a using directive.

class Program  // This is the class declaration.
{
    static void Main()  // This is the Main method, the entry point of our program.
    {
        // This is a single-line comment. It is ignored by the compiler.

        // The following line of code displays "Hello, World!" to the console.
        Console.WriteLine("Hello, World!");

        // The program execution ends here.
    }
}


/* 
Part 2: Explaining Basic Syntax Elements
Variables:
In our "Hello, World!" program, we don't use any variables. However, I'll explain the concept. Variables are used to store and manage data in C#. They have a data type that defines the kind of data they can hold (e.g., int for integers, string for text). Variables are declared with a data type followed by a name. For example, int age; declares an integer variable named "age."

Data Types:
In our program, we don't declare any variables, so we don't specify data types explicitly. However, Console.WriteLine("Hello, World!"); uses a string literal, "Hello, World!", which is of the string data type. Data types in C# specify the type of data a variable can hold. Choosing the right data type ensures efficient memory usage and appropriate data manipulation.

Console Output:
The line Console.WriteLine("Hello, World!"); is responsible for displaying "Hello, World!" to the console. Here's how it works:

Console is a class in the System namespace that provides methods for interacting with the console (command-line interface).
WriteLine is a method of the Console class that outputs a line of text to the console.
"Hello, World!" is a string literal, enclosed in double quotes. It's the text we want to display.
Program Structure:
using System;: This is a using directive. It tells the compiler to include the System namespace, which contains essential classes and methods. In this case, we're using it to access the Console class.
class Program: This is a class declaration. In C#, programs are organized into classes. Our program is defined within the Program class.
static void Main(): This is the Main method. It's the entry point of our program. When you run the program, execution starts here. The static keyword means it belongs to the class itself, not to instances of the class. void indicates that the method doesn't return a value.
Comments:
We use comments in the program to provide explanations and documentation. Comments are ignored by the compiler and are for human readability. Single-line comments start with //, while multi-line comments start with /* and end with */


/* 
1. Open a Terminal or Command Prompt:

On Windows, press Win + R, type cmd, and press Enter.
On macOS, open the Applications folder, then the Utilities folder, and launch Terminal.
On Linux, open your terminal emulator of choice.

2. Navigate to the Directory Containing HelloWorld.cs:

Use the cd command to change to the directory where your HelloWorld.cs file is located.

3. Compile the C# Program:

Use the C# compiler (csc) to compile your program. In this case, you'll compile HelloWorld.cs:
csc HelloWorld.cs


4. Run the Executable:

To run your program, type the name of the executable (without the file extension) and press Enter:
HelloWorld


*/
