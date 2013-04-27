// -----------------------------------------------------------------------
// <copyright file="NameValueCollectionExtension.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace IAnswerable.Utility
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Collections.Specialized;
    using System.Web;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public static class NameValueCollectionExtensions
    {
        public static string ToHtmlEncodedKeyValueString(this NameValueCollection value)
        {
            string[] values = new string[value.Count];

            int i = 0;
            foreach (var pair in value)
            {
                values[i] = string.Format("{0}={1}", pair.ToString(), HttpUtility.UrlEncode(value[pair.ToString()]));
                i++;
            }

            return String.Join("&", values);
        }
    }
}
