using System;

/// <summary>
/// Contains method to check object type.
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
}
