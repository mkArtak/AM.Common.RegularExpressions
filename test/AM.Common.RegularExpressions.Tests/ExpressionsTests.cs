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
            Assert.Matches(Patterns.WholeNumber, value);
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
            Assert.DoesNotMatch(Patterns.WholeNumber, value);
        }

        [InlineData("av@77.cd")]
        [InlineData("av@bc.cd")]
        [InlineData("a_a@bc.co")]
        [InlineData("abc@ba.cd")]
        [InlineData("a_7@b7.com")]
        [InlineData("abcdef_qsz44@77zoro.com")]
        [Theory]
        public void Email_MatchesValidEmail(string value)
        {
            Assert.Matches(Patterns.EmailAddress, value);
        }

        [InlineData("")]
        [InlineData("  ")]
        [InlineData("asdf.com")]
        [InlineData("@asdf.com")]
        [InlineData("av_77.cd")]
        [InlineData("a_!@b#.cd")]
        [InlineData("abc@@ba.cd")]
        [InlineData("a_7.b7@com")]
        [InlineData("abcdef_qsz4477zorocom")]
        [Theory]
        public void Email_DoesNotMatchInvalidEmail(string value)
        {
            Assert.DoesNotMatch(Patterns.EmailAddress, value);
        }
    }
}
