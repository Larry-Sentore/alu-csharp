public class VectorMath
{
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if ((vector1.Length != 2 && vector1.Length != 3) ||
            (vector2.Length != 2 && vector2.Length != 3))
        {
            return new double[] { -1 }; // Return [-1] if any vector is not 2D or 3D
        }

        if (vector1.Length != vector2.Length)
        {
            return new double[] { -1 }; // Return [-1] if vectors are not of the same size
        }

        double[] result = new double[vector1.Length];
        for (int i = 0; i < vector1.Length; i++)
        {
            result[i] = vector1[i] + vector2[i]; // Add corresponding components
        }

        return result;
    }
}