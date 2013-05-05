namespace IAnswerable.Utility
{
    using System.Web.Script.Serialization;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public static class JsonExtensions
    {
        public static string JsonSerialize(this object value)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            return js.Serialize(value);
        }

        public static T JsonDeserialize<T>(this string value)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            return js.Deserialize<T>(value);
        }
    }
}
