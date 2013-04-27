namespace IAnswerable.Utility
{
    using System;
    using System.Linq;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public static class ObjectExtensions
    {
        public static bool IsNotNull(this object Value)
        {
            return Value != null;
        }

        public static string ToStringOrEmptyIfNull(this object Value)
        {
            if (Value.IsNotNull())
            {
                return Value.ToString();
            }

            return string.Empty;
        }

        public static bool In<T>(this T source, params T[] list)
        {
            if (null == source) throw new ArgumentNullException("source");
            return list.Contains(source);
        }

        public static T OneOf<T>(this Random rng, params T[] things)
        {
            return things[rng.Next(things.Length)];
        }
    }
}
