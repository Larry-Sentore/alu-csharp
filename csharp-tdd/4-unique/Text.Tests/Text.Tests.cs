/// <summary> Test cases for the UniqueChar method in the Str class </summary>
using Xunit;
using Text;

namespace Text.Tests
{
    /// <summary> Unit tests for the Str.UniqueChar method </summary>
    public class StrTests
    {
        /// <summary> Theory tests covering various inputs for finding the first unique character </summary>
        [Theory]
        [InlineData("leetcode", 0)]
        [InlineData("loveleetcode", 2)]
        [InlineData("aabb", -1)]
        [InlineData("x", 0)]
        [InlineData("", -1)]
        public void UniqueChar_TestCases(string input, int expected)
        {
            int result = Str.UniqueChar(input);
            Assert.Equal(expected, result);
        }
    }
}
