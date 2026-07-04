using System;

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
}
