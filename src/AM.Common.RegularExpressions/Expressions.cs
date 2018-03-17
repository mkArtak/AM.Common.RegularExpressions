using System.Text.RegularExpressions;

namespace AM.Common.RegularExpressions
{
    public static class Expressions
    {
        public const string NumberPatter = "^[0-9]+$";

        public static readonly Regex Number = new Regex(NumberPatter, RegexOptions.Compiled);
    }
}
