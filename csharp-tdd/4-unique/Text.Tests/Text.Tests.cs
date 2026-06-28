using Xunit;
using Text;

namespace Text.Tests
{
    public class StrTests
    {
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
