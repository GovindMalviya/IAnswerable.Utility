using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IAnswerable.Utility
{
    public static class ConvertExtensions
    {
        public static T To<T>(this IConvertible obj)
        {
            return (T)Convert.ChangeType(obj, typeof(T));
        }
    }
}
