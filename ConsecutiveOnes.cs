using System;

class Program
{
    static void Main()
    {
        // Get the size of the array from the user
        Console.WriteLine("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());

        // Declare the array
        int[] arr = new int[size];

        // Get elements of the array from the user
        Console.WriteLine("Enter elements of the array:");
        for (int i = 0; i < size; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        
        int currentCount = 0;
        int maxCount = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 1)
            {
                currentCount++;
                maxCount = Math.Max(maxCount, currentCount);
            }
            else
            {
                currentCount = 0;
            }
        }
        
        Console.WriteLine("Consecutive Ones:" + maxCount);
       
    }
}
