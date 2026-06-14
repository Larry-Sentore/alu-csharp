using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of Dog using the constructor
        Dog poppy = new Dog("Poppy", 0.7f, "Kris", Rating.Excellent);

        // Printing out the details of the dog using ToString()
        Console.WriteLine(poppy.ToString());
    }
}
