using System;

public class MatrixMath
{
    /// <summary>
    /// Calculates the inverse of a 2D matrix.
    /// </summary>
    /// <param name="matrix">The 2D matrix to calculate the inverse for.</param>
    /// <returns>The inverse of the matrix if it exists, otherwise [-1].</returns>
    public static double[,] Inverse2D(double[,] matrix)
    {
        // Check if the matrix is 2D
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
        {
            // Return [-1] for non-2D matrices
            return new double[,] { { -1 } };
        }

        // Calculate determinant
        double determinant = (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);

        // Check if the matrix is non-invertible (determinant is zero)
        if (Math.Abs(determinant) < 0.0001)
        {
            return new double[,] { { -1 } }; // Return [-1] for non-invertible matrices
        }

        // Calculate the inverse
        double[,] inverse = new double[2, 2];
        inverse[0, 0] = Math.Round(matrix[1, 1] / determinant, 2);
        inverse[0, 1] = Math.Round(-matrix[0, 1] / determinant, 2);
        inverse[1, 0] = Math.Round(-matrix[1, 0] / determinant, 2);
        inverse[1, 1] = Math.Round(matrix[0, 0] / determinant, 2);

        return inverse;
    }
}
