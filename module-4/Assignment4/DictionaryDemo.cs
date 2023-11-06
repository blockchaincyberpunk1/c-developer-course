using System;
using System.Collections.Generic;

class DictionaryDemo
{
    static void Main()
    {
        // Create a dictionary of students and their ages
        Dictionary<string, int> studentAges = new Dictionary<string, int>();

        // Add key-value pairs
        studentAges["Alice"] = 20;
        studentAges["Bob"] = 22;
        studentAges["Charlie"] = 21;

        // Retrieve values by keys
        Console.WriteLine("Age of Alice: " + studentAges["Alice"]);
        Console.WriteLine("Age of Bob: " + studentAges["Bob"]);

        // Remove a key-value pair
        studentAges.Remove("Charlie");

        // Iterate through the dictionary
        Console.WriteLine("\nStudent Ages:");
        foreach (var kvp in studentAges)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value} years old");
        }
    }
}

/*  
In this example, I create a Dictionary<string, int> named studentAges, where string represents the keys (student names), and int represents the values (ages).

Key-value pairs are added to the dictionary using the [] indexer.

Values are retrieved by keys using the [] indexer as well.

I remove a key-value pair from the dictionary using the Remove method.

To iterate through the dictionary, we use a foreach loop, where kvp represents each key-value pair. We display the student names and their ages.
*/
