using System.Collections;
using System.Collections.Generic;

namespace AM.Common.RegularExpressions.Tests.TestData
{
    public class InvalidUrls : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { "httpp://abcdef.gklm" };
            yield return new object[] { "abcdef. gklm" };
            yield return new object[] { "abcdef. gklm" };
            yield return new object[] { "www.google.com asdf" };
            yield return new object[] { "" };
            yield return new object[] { "   " };
            yield return new object[] { "   " };
            yield return new object[] { "asdf" };
            yield return new object[] { "245345" };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
