using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Prompt user for input
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();  // Read user input
        
        FindDuplicateCharacters(input);  // Call method to find duplicates
    }

    static void FindDuplicateCharacters(string str)
    {
        // Dictionary to store character frequency
        Dictionary<char, int> charCount = new Dictionary<char, int>();

        // Loop through the string using for loop
        for (int i = 0; i < str.Length; i++)
        {
            char c = str[i];  // Get the current character

            // If the character exists in the dictionary, increment its count
            if (charCount.ContainsKey(c))
            {
                charCount[c]++;
            }
            else
            {
                // Otherwise, add the character with count 1
                charCount.Add(c, 1);
            }
        }

        // Output duplicate characters using for loop
        bool foundDuplicates = false;
        Console.WriteLine("Duplicate characters in the string:");
        
        // Get the dictionary keys as a list for using in a for loop
        List<char> keys = new List<char>(charCount.Keys);
        
        // Use a for loop to iterate through the dictionary keys
        for (int i = 0; i < keys.Count; i++)
        {
            char key = keys[i];
            if (charCount[key] > 1)
            {
                Console.WriteLine($"{key} appears {charCount[key]} times");
                foundDuplicates = true;
            }
        }

        // If no duplicates found
        if (!foundDuplicates)
        {
            Console.WriteLine("No duplicate characters found.");
        }
    }
}
