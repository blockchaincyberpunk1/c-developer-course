using System;

class Program
{
    static void Main()
    {
        int sum = 0;
        Console.WriteLine("Sum of the first 10 natural numbers:");
        for (int i = 1; i <= 10; i++)
        {
            sum += i;
        }
        Console.WriteLine("Sum: " + sum);
    }
}

/*  
We initialize a variable sum to store the sum of the numbers.
We use a for loop to iterate from 1 to 10 (int i = 1; i <= 10).
Inside the loop, we add each number to the sum variable (sum += i).
After the loop, we use Console.WriteLine to display the sum.
*/
