using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array1 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int[] array2 = null; // Null array
int[] array3 = { }; // Empty array
int[] array4 = { 98, -10, 0, 972, -42 };

Array.Reverse(array1); // Reverse and print array1
Array.Reverse(array2); // Reverse and print array2 (null)
Array.Reverse(array3); // Reverse and print array3 (empty)
Array.Reverse(array4); // Reverse and print array4

    }
}