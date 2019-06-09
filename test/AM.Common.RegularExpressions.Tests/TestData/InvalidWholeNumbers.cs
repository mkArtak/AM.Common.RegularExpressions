using System.Collections;
using System.Collections.Generic;

namespace AM.Common.RegularExpressions.Tests.TestData
{
    public class InvalidWholeNumbers : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { "" };
            yield return new object[] { " " };
            yield return new object[] { "   " };
            yield return new object[] { "1a" };
            yield return new object[] { "a1" };
            yield return new object[] { "1a1" };
            yield return new object[] { "1.0" };
            yield return new object[] { "1,0" };
            yield return new object[] { "a" };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
