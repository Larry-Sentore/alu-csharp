using System;

public class VectorMath
{
    public static double Magnitude(double[] vector)
    {
        int dimensions = vector.Length;
        if (dimensions != 2 && dimensions != 3)
        {
            return -1; // Return -1 for vectors that are not 2D or 3D
        }

        double sumOfSquares = 0;
        foreach (double component in vector)
        {
            sumOfSquares += component * component; // Calculate sum of squares of components
        }

        return Math.Round(Math.Sqrt(sumOfSquares), 2); // Round to nearest hundredth
    }

    public static double[] Add(double[] vector1, double[] vector2)
    {
        int dimensions1 = vector1.Length;
        int dimensions2 = vector2.Length;
        if ((dimensions1 != 2 && dimensions1 != 3) || (dimensions2 != 2 && dimensions2 != 3))
        {
            return new double[] { -1 }; // Return [-1] for vectors that are not 2D or 3D
        }

        if (dimensions1 != dimensions2)
        {
            return new double[] { -1 }; // Return [-1] for vectors of different sizes
        }

        double[] result = new double[dimensions1];
        for (int i = 0; i < dimensions1; i++)
        {
            result[i] = vector1[i] + vector2[i]; // Calculate sum of corresponding components
        }

        return result;
    }

    public static double[] Multiply(double[] vector, double scalar)
    {
        int dimensions = vector.Length;
        if (dimensions != 2 && dimensions != 3)
        {
            return new double[] { -1 }; // Return [-1] for vectors that are not 2D or 3D
        }

        double[] result = new double[dimensions];
        for (int i = 0; i < dimensions; i++)
        {
            result[i] = vector[i] * scalar; // Multiply each component by the scalar
        }

        return result;
    }

    public static double DotProduct(double[] vector1, double[] vector2)
    {
        int dimensions1 = vector1.Length;
        int dimensions2 = vector2.Length;
        if ((dimensions1 != 2 && dimensions1 != 3) || (dimensions2 != 2 && dimensions2 != 3))
        {
            return -1; // Return -1 for vectors that are not 2D or 3D
        }

        if (dimensions1 != dimensions2)
        {
            return -1; // Return -1 for vectors of different sizes
        }

        double dotProduct = 0;
        for (int i = 0; i < dimensions1; i++)
        {
            dotProduct += vector1[i] * vector2[i]; // Calculate sum of products of corresponding components
        }

        return dotProduct;
    }
}