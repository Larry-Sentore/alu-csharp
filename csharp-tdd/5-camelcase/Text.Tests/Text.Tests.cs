using Xunit;
using Text;

namespace Text.Tests
{
    public class StrTests
    {
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
