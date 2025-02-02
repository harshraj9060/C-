using System;

class Program
{
    static void Main()
    {
        // Get the size of the array from the user
        Console.Write("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());

        // Declare the array
        int[] arr = new int[size];

        // Get elements of the array from the user
        Console.WriteLine("Enter elements of the array:");
        for (int i = 0; i < size; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        // Move all zeros to the end of the array
        int index = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != 0)
            {
                arr[index] = arr[i];
                if (index != i)
                {
                    arr[i] = 0; // Place 0 at the original position
                }
                index++;
            }
        }

        // Print the array after moving zeroes
        Console.WriteLine("Array after moving zeroes:");
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
    }
}
