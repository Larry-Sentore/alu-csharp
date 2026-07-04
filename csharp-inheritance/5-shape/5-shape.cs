using System;

/// <summary>
/// Represents a generic shape.
/// </summary>
public class Shape
{
    /// <summary>
    /// Computes the area of the shape.
    /// </summary>
    /// <returns>Area of the shape.</returns>
    /// <exception cref="NotImplementedException">Thrown when method is not implemented.</exception>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}
