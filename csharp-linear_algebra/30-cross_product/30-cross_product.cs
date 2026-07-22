using System;

public class VectorMath
{
    /// <summary>
    /// Calculates the cross product of two 3D vectors.
    /// </summary>
    /// <param name="vector1">The first 3D vector.</param>
    /// <param name="vector2">The second 3D vector.</param>
    /// <returns>The cross product of the two 3D vectors.</returns>
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        // Check if both vectors are 3D
        if (vector1.Length != 3 || vector2.Length != 3)
        {
            // Return vector containing -1 if either vector is not a 3D vector
            return new double[] { -1, -1, -1 };
        }

        // Calculate cross product
        double[] result = new double[3];
        result[0] = (vector1[1] * vector2[2]) - (vector1[2] * vector2[1]);
        result[1] = (vector1[2] * vector2[0]) - (vector1[0] * vector2[2]);
        result[2] = (vector1[0] * vector2[1]) - (vector1[1] * vector2[0]);

        // Check if result is close to zero, consider it as zero
        for (int i = 0; i < 3; i++)
        {
            if (Math.Abs(result[i]) < 0.00001)
            {
                result[i] = 0;
            }
        }

        return result;
    }
}