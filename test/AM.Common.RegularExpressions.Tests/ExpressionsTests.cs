using Xunit;

namespace AM.Common.RegularExpressions.Tests
{
    public class ExpressionsTests
    {
        [InlineData("0123456789")]
        [InlineData("777")]
        [InlineData("1")]
        [Theory]
        public void Number_MatchesWithNumericStrings(string value)
        {
            Assert.Matches(Expressions.Number, value);
        }

        [InlineData("")]
        [InlineData("   ")]
        [InlineData("1b1")]
        [InlineData("a111")]
        [InlineData("111z")]
        [InlineData("aaa")]
        [Theory]
        public void Number_DoesntMatchWithNonNumericStrings(string value)
        {
            Assert.DoesNotMatch(Expressions.Number, value);
        }
    }
}
