namespace AM.Common.RegularExpressions
{
    public static class Patterns
    {
        public const string WholeNumber = "^[0-9]+$";

        public const string EmailAddress = @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?";

        public const string Url = @"(?:(?:https?|ftp):\/\/)?(?:[a-zA-Z0-9_\-]+(?:\.[a-zA-Z0-9]+)+)(?:\/[a-zA-Z0-9#]+[a-zA-Z0-9\-\.]*[a-zA-Z0-9]+)*(?:\?(?:(?:[a-zA-Z0-9_]+(?:[a-zA-Z0-9\+\%]*[a-zA-Z0-9_]+)?)\=(?:[a-zA-Z0-9_\-]+(?:[a-zA-Z0-9\+\%]*[a-zA-Z0-9_\+]+)?)*\&?)+)?\/?";
    }
}
