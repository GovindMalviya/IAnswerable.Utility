namespace IAnswerable.Utility
{
    using System;
    using System.Collections.Specialized;
    using System.Web;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public static class NameValueCollectionExtensions
    {
        public static string ToHtmlEncodedKeyValueString(this NameValueCollection pairs)
        {
            string[] values = new string[pairs.Count];

            int i = 0;
            foreach (var pair in pairs)
            {
                values[i] = string.Format("{0}={1}", pair.ToString(), HttpUtility.UrlEncode(pairs[pair.ToString()]));
                i++;
            }

            return String.Join("&", values);
        }
    }
}
