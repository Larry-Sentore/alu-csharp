public class MatrixMath
{
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        // Get the dimensions of the matrix
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Check if the matrix is either 2D or 3D
        if ((rows != 2 && rows != 3) || (cols != 2 && cols != 3))
        {
            // Return a matrix containing -1 if the matrix is not 2D or 3D
            return new double[,] { { -1 } };
        }

        // Create a new matrix to store the result
        double[,] result = new double[rows, cols];

        // Multiply each element of the matrix by the scalar
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrix[i, j] * scalar;
            }
        }

        return result;
    }
}