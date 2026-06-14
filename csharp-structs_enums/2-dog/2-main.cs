using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of Dog using the constructor
        Dog poppy = new Dog("Poppy", 0.7f, "Kris", Rating.Excellent);

        // Printing out the details of the dog
        Console.WriteLine("My name is {0} and I am {1}. I am an {2} dog. :)", poppy.name, poppy.age, poppy.rating);
    }
}
