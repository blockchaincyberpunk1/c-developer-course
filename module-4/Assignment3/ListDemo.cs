using System;
using System.Collections.Generic;

class ListDemo
{
    static void Main()
    {
        // Initialize a generic list with predefined values
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        // Add a new element to the list
        numbers.Add(6);

        // Display the updated list
        Console.WriteLine("Updated List:");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }

        // Remove an element from the list
        int elementToRemove = 3;
        numbers.Remove(elementToRemove);

        // Display the list after removal
        Console.WriteLine("\nList after removing element {0}:", elementToRemove);
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }

        // Search for an element in the list
        int elementToSearch = 5;
        int indexOfElement = numbers.IndexOf(elementToSearch);

        if (indexOfElement != -1)
        {
            Console.WriteLine("\nElement {0} found at index {1}.", elementToSearch, indexOfElement);
        }
        else
        {
            Console.WriteLine("\nElement {0} not found in the list.", elementToSearch);
        }
    }
}
