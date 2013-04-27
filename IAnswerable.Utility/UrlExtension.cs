namespace IAnswerable.Utility
{
    using System;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public static class UrlExtension
    {
        public static string CombineUrl(this string value, string relativeUrl)
        {
            Uri baseUri = new Uri(value);
            Uri myUri = new Uri(baseUri, relativeUrl);
            return myUri.ToString();
        }

        public static string RemoveTrailSlash(this string value)
        {
            if (value.EndsWith("/"))
            {
                return value.Remove((value.Length - 1), 1);
            }

            return value;
        }
    }
}
