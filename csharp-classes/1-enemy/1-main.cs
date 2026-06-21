using Enemies;
using System;

/// <summary>
/// Entry point of the program.
/// </summary>
class Program
{
    /// <summary>
    /// Main method that creates a Zombie object and displays its type and health.
    /// </summary>
    static void Main(string[] args)
    {
        Zombie newObject = new Zombie();

        Console.WriteLine("newObject is of type {0} and has a total of {1} health", newObject.GetType(), newObject.health);
    }
}
