using Xunit;
using MyMath;
using System.Collections.Generic;

namespace MyMath.Tests
{
    public class OperationsTests
    {
        [Fact]
        public void Max_WithMultipleIntegers_ReturnsCorrectMax()
        {
            List<int> nums = new List<int> { 1, 3, 7, 2, 5 };
            int result = Operations.Max(nums);
            Assert.Equal(7, result);
        }

        [Fact]
        public void Max_WithNegativeIntegers_ReturnsCorrectMax()
        {
            List<int> nums = new List<int> { -10, -20, -3 };
            int result = Operations.Max(nums);
            Assert.Equal(-3, result);
        }

        [Fact]
        public void Max_WithEmptyList_ReturnsZero()
        {
            List<int> nums = new List<int>();
            int result = Operations.Max(nums);
            Assert.Equal(0, result);
        }

        [Fact]
        public void Max_WithNullList_ReturnsZero()
        {
            int result = Operations.Max(null);
            Assert.Equal(0, result);
        }
    }
}
