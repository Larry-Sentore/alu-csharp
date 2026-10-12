using System;

/// <summary>
/// generic queue.
/// </summary>
public class Queue<T>
{
    /// <summary>
    /// Gets the type used by this queue and returns the type.
    /// </summary>
    public Type CheckType()
    {
        return typeof(T);
    }
}
