/// <summary> Test cases for the CamelCase method in the Str class </summary>
using Xunit;
using Text;

namespace Text.Tests
{
    /// <summary> Unit tests for the Str.CamelCase method </summary>
    public class StrTests
    {
        /// <summary> Theory tests covering various camelCase strings and their expected word counts </summary>
        [Theory]
        [InlineData("helloWorld", 2)]
        [InlineData("thisIsCamelCase", 4)]
        [InlineData("single", 1)]
        [InlineData("", 0)]
        [InlineData("alreadyLower", 2)]
        public void CamelCase_TestCases(string input, int expected)
        {
            int result = Str.CamelCase(input);
            Assert.Equal(expected, result);
        }
    }
}
