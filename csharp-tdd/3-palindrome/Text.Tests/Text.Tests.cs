using Xunit;
using Text;

namespace Text.Tests
{
    public class StrTests
    {
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
