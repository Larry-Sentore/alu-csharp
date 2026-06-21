using Enemies;
using System;

class Program
{
    static void Main(string[] args)
    {
        Zombie newObject = new Zombie();
         /// <summary>
    /// Define obeject here.
    /// </summary>
        Console.WriteLine("newObject is of type {0}", newObject.GetType());
        Console.WriteLine("String representation: {0}", newObject.ToString());
    }
}
