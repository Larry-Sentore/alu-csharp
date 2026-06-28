using Xunit;
using MyMath;

namespace MyMath.Tests
{
    public class MatrixTests
    {
        [Fact]
        public void Divide_ValidMatrixAndNonZeroNum_ReturnsDividedMatrix()
        {
            int[,] matrix = { { 2, 4 }, { 6, 8 } };
            int[,] expected = { { 1, 2 }, { 3, 4 } };

            int[,] result = Matrix.Divide(matrix, 2);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Divide_ByZero_PrintsMessageAndReturnsNull()
        {
            int[,] matrix = { { 1, 2 } };
            int[,] result = Matrix.Divide(matrix, 0);

            Assert.Null(result);
        }

        [Fact]
        public void Divide_NullMatrix_ReturnsNull()
        {
            int[,] result = Matrix.Divide(null, 3);

            Assert.Null(result);
        }
    }
}
