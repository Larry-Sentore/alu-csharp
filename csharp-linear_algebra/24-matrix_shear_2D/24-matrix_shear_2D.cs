using System;

public class MatrixMath
{
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Check if matrix is valid n x 2
        if (cols != 2 || rows < 1)
        {
            return new double[,] { { -1 } };
        }

        // Validate direction
        if (direction != 'x' && direction != 'y')
        {
            return new double[,] { { -1 } };
        }

        double[,] result = new double[rows, 2];

        for (int i = 0; i < rows; i++)
        {
            double x = matrix[i, 0];
            double y = matrix[i, 1];

            if (direction == 'x')
            {
                result[i, 0] = Math.Round(x + factor * y, 2, MidpointRounding.AwayFromZero);
                result[i, 1] = Math.Round(y, 2, MidpointRounding.AwayFromZero);
            }
            else // direction == 'y'
            {
                result[i, 0] = Math.Round(x, 2, MidpointRounding.AwayFromZero);
                result[i, 1] = Math.Round(y + factor * x, 2, MidpointRounding.AwayFromZero);
            }
        }

        return result;
    }
}
