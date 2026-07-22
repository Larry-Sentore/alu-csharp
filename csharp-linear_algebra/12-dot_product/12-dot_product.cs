public class VectorMath
{
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        // Check if both vectors are either 2D or 3D
        int dimensions1 = vector1.Length;
        int dimensions2 = vector2.Length;
        if ((dimensions1 != 2 && dimensions1 != 3) || (dimensions2 != 2 && dimensions2 != 3))
        {
            return -1; // Return -1 if any vector is not 2D or 3D
        }

        // Check if both vectors have the same size
        if (dimensions1 != dimensions2)
        {
            return -1; // Return -1 if vectors are not the same size
        }

        // Calculate dot product
        double dotProduct = 0;
        for (int i = 0; i < dimensions1; i++)
        {
            dotProduct += vector1[i] * vector2[i];
        }

        return dotProduct;
    }
}