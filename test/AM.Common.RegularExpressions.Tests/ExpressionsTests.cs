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

        [InlineData("https://www.regexr.com/")]
        [InlineData("https://regexr.com/")]
        [InlineData("http://regexr.com/")]
        [InlineData("http://www.regexr.com/")]
        [InlineData("https://www.regexr.com")]
        [InlineData("https://regexr.com")]
        [InlineData("http://regexr.com")]
        [InlineData("http://www.regexr.com")]
        [InlineData("https://analytics.google.com/analytics/web/#embed/report-home/a1053531sdfsdfsfsdf33w157273318p158783999/")]
        [InlineData("https://www.bing.com/search?q=something+very+special+&qs=n&form=QBLH&sp=-1&pq=something+very+special+&sc=6-23&sk=&cvid=66621BEC9C8845D4B9157AA63516C6A5")]
        [Theory]
        public void Url_MatchesValidUrl(string value)
        {
            Assert.Matches(Patterns.Url, value);
        }

        [InlineData("")]
        [InlineData(" ")]
        [InlineData("httpp://abcdef.gklm")]
        [InlineData("abcdef. gklm")]
        [InlineData("abcdef .gklm")]
        [Theory]
        public void Url_DoesntMatchWithInvalidUrl(string value)
        {
            Assert.DoesNotMatch(Patterns.Url, value);
        }
    }
}
