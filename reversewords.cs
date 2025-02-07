using System;

class Program
{
    static void Main()
    {
        // Prompt the user for input
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        
        // Reverse each word in the string and display the result
        Console.WriteLine("Reversed Words: " + ReverseWords(input));
    }

    static string ReverseWords(string input)
    {
        string[] words = input.Split(' '); // Split the input string into words
        for (int i = 0; i < words.Length; i++)
        {
            // Reverse each word directly inside the loop
            char[] wordArray = words[i].ToCharArray();
            Array.Reverse(wordArray);
            words[i] = new string(wordArray);
        }
        return string.Join(" ", words); // Join the reversed words back into a string
    }
}
