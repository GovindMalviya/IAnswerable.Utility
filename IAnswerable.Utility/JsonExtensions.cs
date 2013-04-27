// -----------------------------------------------------------------------
// <copyright file="JsonExtension.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace IAnswerable.Utility
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Web.Script.Serialization;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public static class JsonExtensions
    {
        public static string ToJSON(this object value)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            return js.Serialize(value);
        }

        public static T ToJson<T>(this string value, T Object)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            return js.Deserialize<T>(value);
        }
    }
}
