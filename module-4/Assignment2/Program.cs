using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "sample.txt";

        if (File.Exists(filePath))
        {
            string content = File.ReadAllText(filePath);
            Console.WriteLine("File content:");
            Console.WriteLine(content);
        }
        else
        {
            Console.WriteLine("The file does not exist.");
        }
    }
}
