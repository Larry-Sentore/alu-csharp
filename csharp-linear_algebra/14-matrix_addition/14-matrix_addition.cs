using System;

public class MatrixMath
{
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        // Get the dimensions of the matrices
        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int cols2 = matrix2.GetLength(1);

        // Check if both matrices are either both 2D or both 3D
        if ((rows1 != 2 && rows1 != 3) || (cols1 != 2 && cols1 != 3) || 
            (rows2 != 2 && rows2 != 3) || (cols2 != 2 && cols2 != 3))
        {
            // Return a matrix containing -1 if any matrix is not 2D or 3D
            return new double[,] { { -1 } };
        }

        // Check if both matrices have the same size
        if (rows1 != rows2 || cols1 != cols2)
        {
            // Return a matrix containing -1 if matrices are not the same size
            return new double[,] { { -1 } };
        }

        // Create a new matrix to store the result
        double[,] result = new double[rows1, cols1];

        // Add corresponding elements of the matrices
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols1; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        return result;
    }
}