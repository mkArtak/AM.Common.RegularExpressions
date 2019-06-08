using Xunit;

namespace AM.Common.RegularExpressions.Tests
{
    public class PatternMatcherTests
    {
        [InlineData("https://microsoft.com")]
        [InlineData("https://sharetwist.com")]
        [InlineData("https://sharetwist.com/v/1061144626190608ui70iqxq39i_hq")]
        [Theory]
        public void IsMatch_ReturnsTrueForValidUrls(string value)
        {
            Assert.True(PatternMatcher.Is(value, ContentType.Url));
        }

        [Fact]
        public void IsMatch_ReturnsFalseForNull()
        {
            Assert.False(PatternMatcher.Is(null, ContentType.Url));
        }

        [Fact]
        public void IsMatch_ReturnsFalseForEmptyString()
        {
            Assert.False(PatternMatcher.Is(string.Empty, ContentType.Url));
        }
    }
}
