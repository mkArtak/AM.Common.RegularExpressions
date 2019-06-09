using System.Collections;
using System.Collections.Generic;

namespace AM.Common.RegularExpressions.Tests.TestData
{
    public class InvalidEmails : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { "" };
            yield return new object[] { " " };
            yield return new object[] { "   " };
            yield return new object[] { "abcd" };
            yield return new object[] { "asdf.com" };
            yield return new object[] { "@asdv" };
            yield return new object[] { "@bc.co" };
            yield return new object[] { "abc@@ba.cd" };
            yield return new object[] { "a_7.b3@b7@com" };
            yield return new object[] { "abcdef_qsz4477zorocom" };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
