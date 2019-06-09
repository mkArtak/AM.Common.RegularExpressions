using System.Collections;
using System.Collections.Generic;

namespace AM.Common.RegularExpressions.Tests.TestData
{
    public class ValidEmails : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { "1234@testemail.com" };
            yield return new object[] { "abcd@testemail.com" };
            yield return new object[] { "1_2asdf@testemail.com" };
            yield return new object[] { "__234234@testemai.email.com" };
            yield return new object[] { "av@77.cd" };
            yield return new object[] { "av@bc.cd" };
            yield return new object[] { "a_a@bc.co" };
            yield return new object[] { "abc@ba.cd" };
            yield return new object[] { "a_7@b7.com" };
            yield return new object[] { "abcdef_qsz44@77zoro.com" };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
