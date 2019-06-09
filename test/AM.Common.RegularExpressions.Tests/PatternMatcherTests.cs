using AM.Common.RegularExpressions.Tests.TestData;
using Xunit;

namespace AM.Common.RegularExpressions.Tests
{
    public class PatternMatcherTests
    {
        [Theory]
        [ClassData(typeof(ValidUrls))]
        public void IsMatch_ReturnsTrueForValidUrls(string value)
        {
            Assert.True(PatternMatcher.Is(value, ContentType.Url));
        }

        [Theory]
        [ClassData(typeof(InvalidUrls))]
        public void IsMatch_ReturnsFalseForInvalidUrls(string value)
        {
            Assert.False(PatternMatcher.Is(value, ContentType.Url));
        }

        [Theory]
        [ClassData(typeof(ValidEmails))]
        public void IsMatch_ReturnsTrueForValidEmails(string value)
        {
            Assert.True(PatternMatcher.Is(value, ContentType.Email));
        }

        [Theory]
        [ClassData(typeof(InvalidEmails))]
        public void IsMatch_ReturnsFalseForInvalidEmails(string value)
        {
            Assert.False(PatternMatcher.Is(value, ContentType.Email));
        }

        [Theory]
        [ClassData(typeof(ValidWholeNumbers))]
        public void IsMatch_ReturnsTrueForValidwholeNumbers(string value)
        {
            Assert.True(PatternMatcher.Is(value, ContentType.WholeNumber));
        }

        [Theory]
        [ClassData(typeof(InvalidWholeNumbers))]
        public void IsMatch_ReturnsFalseForInvalidwholeNumbers(string value)
        {
            Assert.False(PatternMatcher.Is(value, ContentType.WholeNumber));
        }
    }
}
