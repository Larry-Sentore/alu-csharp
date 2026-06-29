/// <summary> Test cases for the IsPalindrome method in the Str class </summary>
using Xunit;
using Text;

namespace Text.Tests
{
    /// <summary> Unit tests for the Str.IsPalindrome method </summary>
    public class StrTests
    {
        /// <summary> Theory tests covering various palindrome and non-palindrome inputs </summary>
        [Theory]
        [InlineData("Racecar", true)]
        [InlineData("level", true)]
        [InlineData("A man, a plan, a canal: Panama.", true)]
        [InlineData("Not a palindrome", false)]
        [InlineData("", true)]
        [InlineData(" ", true)]
        [InlineData(null, false)]
        public void IsPalindrome_TestCases(string input, bool expected)
        {
            bool result = Str.IsPalindrome(input);
            Assert.Equal(expected, result);
        }
    }
}
