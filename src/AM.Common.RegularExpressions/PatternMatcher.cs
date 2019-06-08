using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AM.Common.RegularExpressions
{
    /// <summary>
    /// This class provides static functionality for checking string content type.
    /// </summary>
    public static class PatternMatcher
    {
        /// <summary>
        /// Checks whether the provided string content is of provided type.
        /// </summary>
        /// <param name="value">The string value to check.</param>
        /// <param name="type">The type of the contentn to check for.</param>
        /// <returns>true, if the content is of specified type. false, otherwise.</returns>
        public static bool Is(string value, ContentType type)
        {
            if (value == null)
            {
                return false;
            }

            string pattern;
            switch (type)
            {
                case ContentType.WholeNumber:
                    pattern = Patterns.WholeNumber;
                    break;

                case ContentType.Url:
                    pattern = Patterns.Url;
                    break;

                case ContentType.Email:
                    pattern = Patterns.EmailAddress;
                    break;
                default:
                    return false;
            }

            return Regex.IsMatch(value, pattern);
        }
    }
}
