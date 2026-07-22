using System;

public class MatrixMath
{
    /// <summary>
    /// Transposes a matrix and returns the resulting matrix.
    /// </summary>
    /// <param name="matrix">The matrix to transpose.</param>
    /// <returns>The transposed matrix.</returns>
    public static double[,] Transpose(double[,] matrix)
    {
        // Check if the matrix is empty
        if (matrix.Length == 0)
        {
            return new double[0, 0]; // Return an empty matrix
        }

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Create a new matrix to store the transposed values
        double[,] transposedMatrix = new double[cols, rows];

        // Perform the transpose operation
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                transposedMatrix[j, i] = matrix[i, j];
            }
        }

        return transposedMatrix;
    }
}
