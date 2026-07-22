using System;

/// <summary>
/// Provides methods for matrix operations.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Multiplies two matrices and returns the resulting matrix.
    /// </summary>
    /// <param name="matrix1">The first matrix.</param>
    /// <param name="matrix2">The second matrix.</param>
    /// <returns>The resulting matrix after multiplication.</returns>
    /// <remarks>
    /// The matrices will not necessarily be square or the same dimensions.
    /// If the matrices cannot be multiplied, the method returns a matrix containing -1.
    /// </remarks>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        // Get the dimensions of the matrices
        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int cols2 = matrix2.GetLength(1);

        // Check if the matrices can be multiplied
        if (cols1 != rows2)
        {
            // Return a matrix containing -1 if the matrices cannot be multiplied
            return new double[,] { { -1 } };
        }

        // Create a new matrix to store the result
        double[,] result = new double[rows1, cols2];

        // Perform matrix multiplication
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                double sum = 0;
                for (int k = 0; k < cols1; k++)
                {
                    sum += matrix1[i, k] * matrix2[k, j];
                }
                result[i, j] = sum;
            }
        }

        return result;
    }
}
