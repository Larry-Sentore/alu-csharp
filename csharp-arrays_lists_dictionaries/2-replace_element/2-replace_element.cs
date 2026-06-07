using System;

public class Array
{
    public static int[] ReplaceElement(int[] array, int index, int n)
    {
        if (index < 0 || index >= array.Length)
        {
            Console.WriteLine("Index out of range");
            return array; // Return the unchanged array
        }

        array[index] = n; // Replace the element at the given index
        return array;     // Return the updated array
    }
}