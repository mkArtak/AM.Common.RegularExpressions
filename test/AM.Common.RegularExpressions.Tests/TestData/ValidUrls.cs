using System.Collections;
using System.Collections.Generic;

namespace AM.Common.RegularExpressions.Tests.TestData
{
    public class ValidUrls : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { "https://www.regexr.com/" };
            yield return new object[] { "https://regexr.com/" };
            yield return new object[] { "http://regexr.com/" };
            yield return new object[] { "http://www.regexr.com/" };
            yield return new object[] { "https://www.regexr.com" };
            yield return new object[] { "https://regexr.com" };
            yield return new object[] { "http://regexr.com" };
            yield return new object[] { "http://www.regexr.com" };
            yield return new object[] { "https://analytics.google.com/analytics/web/#embed/report-home/a1053531sdfsdfsfsdf33w157273318p158783999/" };
            yield return new object[] { "https://www.bing.com/search?q=something+very+special+&qs=n&form=QBLH&sp=-1&pq=something+very+special+&sc=6-23&sk=&cvid=66621BEC9C8845D4B9157AA63516C6A5" };
            yield return new object[] { "https://medium.com/p/9e53ca408c48" };
            yield return new object[] { "https://sharetwist.com/v/1061144626190608ui70iqxq39i_hq" };
            yield return new object[] { "https://medium.com/@ev/welcome-to-medium-9e53ca408c48" };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
