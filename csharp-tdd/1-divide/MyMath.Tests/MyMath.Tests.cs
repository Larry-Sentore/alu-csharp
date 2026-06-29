/// <summary> Test cases for the Divide method in the Matrix class </summary>
using Xunit;
using MyMath;

namespace MyMath.Tests
{
    /// <summary> Unit tests for the Matrix.Divide method </summary>
    public class MatrixTests
    {
        /// <summary> Test that dividing a valid matrix by a non-zero number returns the correctly divided matrix </summary>
        [Fact]
        public void Divide_ValidMatrixAndNonZeroNum_ReturnsDividedMatrix()
        {
            int[,] matrix = { { 2, 4 }, { 6, 8 } };
            int[,] expected = { { 1, 2 }, { 3, 4 } };

            int[,] result = Matrix.Divide(matrix, 2);

            Assert.Equal(expected, result);
        }

        /// <summary> Test that dividing by zero prints a message and returns null </summary>
        [Fact]
        public void Divide_ByZero_PrintsMessageAndReturnsNull()
        {
            int[,] matrix = { { 1, 2 } };
            int[,] result = Matrix.Divide(matrix, 0);

            Assert.Null(result);
        }

        /// <summary> Test that passing a null matrix returns null </summary>
        [Fact]
        public void Divide_NullMatrix_ReturnsNull()
        {
            int[,] result = Matrix.Divide(null, 3);

            Assert.Null(result);
        }
    }
}
