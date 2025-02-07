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
        
        int miss = 0;
        int rep = 0;
        for(int i=0;i<size;i++)
        {
            int cnt = 0;
            bool found = false;
            for(int j=0;j<size;j++)
            {
                if(arr[i] == arr[j])
                {
                    cnt +=1;
                    found = true;
                }
                if(!found)
                {
                    miss = i;
                }
            }
            if(cnt == 2)
            {
                rep = arr[i];
            }
        }
        
        Console.WriteLine("Missing no:" + miss);
        Console.WriteLine("repeating no:" + rep);
       
    }
}
