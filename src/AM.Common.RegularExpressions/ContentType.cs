namespace AM.Common.RegularExpressions
{
    /// <summary>
    /// Represents the type of content of a string.
    /// </summary>
    public enum ContentType
    {
        /// <summary>
        /// Unkonwn type. Applies to a string, which doesn't match with any other known type.
        /// </summary>
        Unkonwn,

        /// <summary>
        /// Represents whole numbers.
        /// </summary>
        WholeNumber,

        /// <summary>
        /// Represents a url.
        /// </summary>
        Url,

        /// <summary>
        /// Represents an email address.
        /// </summary>
        Email,
    }
}
