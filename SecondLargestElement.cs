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

        
        int max1 = arr[0];
        int max2 = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max1)
            {
                max2 = max1;
                max1 = arr[i];
            }
            else if(arr[i] > max2)
            {
                max2 = arr[i];
            }
        }
        
        Console.WriteLine("Second largest number:" + max2);
       
    }
}
