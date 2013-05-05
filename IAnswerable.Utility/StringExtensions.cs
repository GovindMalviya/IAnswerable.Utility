namespace IAnswerable.Utility
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Web;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public static class StringExtensions
    {
        public static bool IsNotNullOrEmptyOrWhiteSpace(this string Value)
        {
            return !(string.IsNullOrEmpty(Value) || string.IsNullOrWhiteSpace(Value));
        }

        public static bool IsHtmlString(this string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return false;
            }

            if (Regex.IsMatch(value, "<.*?>"))
            {
                return true;
            }

            return false;
        }

        public static string UppercaseFirst(this string s)
        {
            // Check for empty string.
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }

            // Return char and concat substring.
            return char.ToUpper(s[0]) + s.Substring(1);
        }

        // Enable quick and more natural string.Format calls
        public static string Format(this string s, params object[] args)
        {
            return string.Format(s, args);
        }

        public static byte[] ToByteArray(this string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentException("String object must have value.", "string");
            }

            return Encoding.ASCII.GetBytes(str);

        }

        public static string UrlEncode(this string str)
        {
            return HttpUtility.UrlEncode(str);
        }

        public static string UrlDecode(this string str)
        {
            return HttpUtility.UrlDecode(str);
        }

        public static string HtmlEncode(this string str)
        {
            return HttpUtility.HtmlEncode(str);
        }

        public static string HtmlDecode(this string str)
        {
            return HttpUtility.HtmlDecode(str);
        }

    }
}
