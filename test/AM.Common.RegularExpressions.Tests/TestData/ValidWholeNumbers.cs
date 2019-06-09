using System.Collections;
using System.Collections.Generic;

namespace AM.Common.RegularExpressions.Tests.TestData
{
    public class ValidWholeNumbers : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { "0" };
            yield return new object[] { "01" };
            yield return new object[] { "10" };
            yield return new object[] { "1234567890" };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
