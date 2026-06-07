using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 0, 1, 2, 3, 4, 5, 6 };

        PrintArray(array); // Print the original array
        Array.ReplaceElement(array, 1, 98); // Replace element at index 1 with 98
        PrintArray(array); // Print the updated array
    }

    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i < array.Length - 1)
                Console.Write(" "); // Add a space between elements
        }
        Console.WriteLine();
    }
}