using System;

class ArrayDemo
{
    static void Main()
    {
        // Initialize an integer array with predefined values
        int[] numbers = { 1, 2, 3, 4, 5 };

        // Add a new element to the array
        int[] updatedNumbers = new int[numbers.Length + 1];
        Array.Copy(numbers, updatedNumbers, numbers.Length);
        updatedNumbers[numbers.Length] = 6;

        // Display the updated array
        Console.WriteLine("Updated Array:");
        foreach (var number in updatedNumbers)
        {
            Console.WriteLine(number);
        }

        // Remove an element from the array
        int elementToRemove = 3;
        updatedNumbers = RemoveElementFromArray(updatedNumbers, elementToRemove);

        // Display the array after removal
        Console.WriteLine("\nArray after removing element {0}:", elementToRemove);
        foreach (var number in updatedNumbers)
        {
            Console.WriteLine(number);
        }
    }

    // Helper method to remove an element from an array
    static int[] RemoveElementFromArray(int[] array, int elementToRemove)
    {
        int[] result = new int[array.Length - 1];
        int index = 0;
        foreach (var number in array)
        {
            if (number != elementToRemove)
            {
                result[index] = number;
                index++;
            }
        }
        return result;
    }
}
