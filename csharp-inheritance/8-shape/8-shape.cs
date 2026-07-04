using System;

/// <summary>
/// Base class Shape
/// </summary>
public class Shape
{
    /// <summary>
    /// Virtual method Area() to be overridden
    /// </summary>
    /// <returns>Throws NotImplementedException</returns>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

/// <summary>
/// Rectangle class inherits from Shape
/// </summary>
public class Rectangle : Shape
{
    private int width;
    private int height;

    /// <summary>
    /// Gets or sets the width of the rectangle
    /// </summary>
    public int Width
    {
        get { return width; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            width = value;
        }
    }

    /// <summary>
    /// Gets or sets the height of the rectangle
    /// </summary>
    public int Height
    {
        get { return height; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            height = value;
        }
    }

    /// <summary>
    /// Overrides the Area method to calculate rectangle area
    /// </summary>
    /// <returns>Area of the rectangle</returns>
    public new int Area()
    {
        return width * height;
    }

    /// <summary>
    /// Overrides ToString() to return the rectangle representation
    /// </summary>
    /// <returns>String representation of Rectangle</returns>
    public override string ToString()
    {
        return $"[Rectangle] {width} / {height}";
    }
}

/// <summary>
/// Square class inherits from Rectangle
/// </summary>
public class Square : Rectangle
{
    private int size;

    /// <summary>
    /// Gets or sets the size of the square
    /// </summary>
    public int Size
    {
        get { return size; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Size must be greater than or equal to 0");
            
            size = value;
            Width = value;
            Height = value;
        }
    }
}
