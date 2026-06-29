/// <summary> Test cases for the Max method in the Operations class </summary>
using Xunit;
using MyMath;
using System.Collections.Generic;

namespace MyMath.Tests
{
    /// <summary> Unit tests for the Operations.Max method </summary>
    public class OperationsTests
    {
        /// <summary> Test that Max returns the correct maximum from a list of positive integers </summary>
        [Fact]
        public void Max_WithMultipleIntegers_ReturnsCorrectMax()
        {
            List<int> nums = new List<int> { 1, 3, 7, 2, 5 };
            int result = Operations.Max(nums);
            Assert.Equal(7, result);
        }

        /// <summary> Test that Max returns the correct maximum from a list of negative integers </summary>
        [Fact]
        public void Max_WithNegativeIntegers_ReturnsCorrectMax()
        {
            List<int> nums = new List<int> { -10, -20, -3 };
            int result = Operations.Max(nums);
            Assert.Equal(-3, result);
        }

        /// <summary> Test that Max returns zero for an empty list </summary>
        [Fact]
        public void Max_WithEmptyList_ReturnsZero()
        {
            List<int> nums = new List<int>();
            int result = Operations.Max(nums);
            Assert.Equal(0, result);
        }

        /// <summary> Test that Max returns zero for a null list </summary>
        [Fact]
        public void Max_WithNullList_ReturnsZero()
        {
            int result = Operations.Max(null);
            Assert.Equal(0, result);
        }
    }
}
