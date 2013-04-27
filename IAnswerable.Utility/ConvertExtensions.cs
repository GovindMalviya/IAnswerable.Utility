namespace IAnswerable.Utility
{
    using System;

    public static class ConvertExtensions
    {
        /// <summary>
        /// Convert to passed type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static T To<T>(this IConvertible obj)
        {
            return (T)Convert.ChangeType(obj, typeof(T));
        }
    }
}
