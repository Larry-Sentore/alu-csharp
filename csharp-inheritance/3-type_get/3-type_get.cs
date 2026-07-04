using System;
using System.Reflection;

/// <summary>
/// Contains methods to check object types.
/// </summary>
public class Obj
{
    /// <summary>
    /// Determines if the given object is of type int.
    /// </summary>
    /// <param name="obj">The object to check.</param>
    /// <returns>True if obj is an int, otherwise False.</returns>
    public static bool IsOfTypeInt(object obj)
    {
        return obj is int;
    }

    /// <summary>
    /// Determines if the given object is an instance of, or inherits from, Array.
    /// </summary>
    /// <param name="obj">The object to check.</param>
    /// <returns>True if obj is an instance of or inherits from Array, otherwise False.</returns>
    public static bool IsInstanceOfArray(object obj)
    {
        return obj is Array;
    }

    /// <summary>
    /// Determines if the given type is a subclass of a specified base type.
    /// </summary>
    /// <param name="derivedType">The derived type to check.</param>
    /// <param name="baseType">The base type to compare against.</param>
    /// <returns>True if derivedType is a subclass of baseType, otherwise False.</returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return derivedType.IsSubclassOf(baseType);
    }

    /// <summary>
    /// Prints the names of the available properties and methods of an object.
    /// </summary>
    /// <param name="myObj">The object to inspect.</param>
    public static void Print(object myObj)
    {
        Type objType = myObj.GetType();
        Console.WriteLine($"{objType.Name} Properties:");
        foreach (PropertyInfo prop in objType.GetProperties())
        {
            Console.WriteLine(prop.Name);
        }
        
        Console.WriteLine($"{objType.Name} Methods:");
        foreach (MethodInfo method in objType.GetMethods())
        {
            Console.WriteLine(method.Name);
        }
    }
}

/// <summary>
/// Represents a Dog with a Name property and a Bark method.
/// </summary>
public class Dog
{
    /// <summary>
    /// Gets or sets the name of the dog. Default value is "Unnamed".
    /// </summary>
    public string Name { get; set; } = "Unnamed";

    /// <summary>
    /// Makes the dog bark.
    /// </summary>
    public void Bark()
    {
        Console.WriteLine("Woof!");
    }
}
