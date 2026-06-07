using System;

class Program
{
    static void Main(string[] args)
    {
        // Initialize a 5x5 two-dimensional array
        int[,] array = new int[5, 5];

        // Set index [2,2] to 1
        array[2, 2] = 1;

        // Print the array
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j]);
                if (j != array.GetLength(1) - 1)
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}