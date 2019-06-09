using AM.Common.RegularExpressions.Tests.TestData;
using Xunit;

namespace AM.Common.RegularExpressions.Tests
{
    public class ExpressionsTests
    {
        [Theory]
        [ClassData(typeof(ValidWholeNumbers))]
        public void Number_MatchesWithNumericStrings(string value)
        {
            Assert.Matches(Patterns.WholeNumber, value);
        }

        [Theory]
        [ClassData(typeof(InvalidWholeNumbers))]
        public void Number_DoesntMatchWithNonNumericStrings(string value)
        {
            Assert.DoesNotMatch(Patterns.WholeNumber, value);
        }

        [Theory]
        [ClassData(typeof(ValidEmails))]
        public void Email_MatchesValidEmail(string value)
        {
            Assert.Matches(Patterns.EmailAddress, value);
        }

        [Theory]
        [ClassData(typeof(InvalidEmails))]
        public void Email_DoesNotMatchInvalidEmail(string value)
        {
            Assert.DoesNotMatch(Patterns.EmailAddress, value);
        }

        [Theory]
        [ClassData(typeof(ValidUrls))]
        public void Url_MatchesValidUrl(string value)
        {
            Assert.Matches(Patterns.Url, value);
        }

        [Theory]
        [ClassData(typeof(InvalidUrls))]
        public void Url_DoesntMatchWithInvalidUrl(string value)
        {
            Assert.DoesNotMatch(Patterns.Url, value);
        }
    }
}
