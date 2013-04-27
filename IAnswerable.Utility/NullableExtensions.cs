namespace IAnswerable.Utility
{
    using System;
    using System.ComponentModel;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public static class NullableExtensions
    {
        public static Nullable<T> ToNullable<T>(this object value) where T : struct
        {
            Nullable<T> result = new Nullable<T>();

            if (value.IsNotNull())
            {
                TypeConverter conv = TypeDescriptor.GetConverter(typeof(T));
                result = (T)conv.ConvertFrom(value);
            }

            return result;
        }
    }
}
