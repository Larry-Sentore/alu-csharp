using System;

public class VectorMath
{
    public static double Magnitude(double[] vector)
    {
        // Check if the vector is 2D or 3D
        if (vector.Length != 2 && vector.Length != 3)
            return -1;

        double sumOfSquares = 0;

        // Calculate sum of squares of the components
        foreach (double component in vector)
        {
            sumOfSquares += component * component;
        }

        // Compute square root and round to nearest hundredth
        double magnitude = Math.Sqrt(sumOfSquares);
        return Math.Round(magnitude, 2);
    }
}
