// -----------------------------------------------------------------------
// <copyright file="NullableExtension.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace IAnswerable.Utility
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.ComponentModel;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public static class NullableExtensions
    {
        public static Nullable<T> ToNullable<T>(this object value) where T : struct
        {
            Nullable<T> result = new Nullable<T>();
            try
            {
                if (value.IsNotNull())
                {
                    TypeConverter conv = TypeDescriptor.GetConverter(typeof(T));
                    result = (T)conv.ConvertFrom(value);
                }
            }
            catch { }
            return result;
        }
    }
}
