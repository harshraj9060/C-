using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Prompt user for input
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();  // Read user input
        
        FindUniqueCharacters(input);  // Call method to find unique characters
    }

    static void FindUniqueCharacters(string str)
    {
        // Dictionary to store character frequency
        Dictionary<char, int> charCount = new Dictionary<char, int>();

        // Loop through the string to count each character's occurrences
        foreach (char c in str)
        {
            if (charCount.ContainsKey(c))
            {
                charCount[c]++;
            }
            else
            {
                charCount.Add(c, 1);
            }
        }

        // Output unique characters (those with count 1)
        bool foundUnique = false;
     //   Console.WriteLine("Unique characters in the string:");
        foreach (var entry in charCount)
        {
            if (entry.Value == 1)
            {
                Console.WriteLine(entry.Key);
                foundUnique = true;
            }
        }

        // If no unique characters were found
        if (!foundUnique)
        {
            Console.WriteLine("No unique characters found.");
        }
    }
}
