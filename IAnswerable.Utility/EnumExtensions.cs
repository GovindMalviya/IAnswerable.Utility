namespace IAnswerable.Utility
{
    using System;
    using System.ComponentModel;
    using System.Reflection;
    using System.Linq;
using System.Collections.Generic;

    public static class EnumHelper
    {
        public static string GetDescription( Enum en)
        {
            Type type = en.GetType();

            MemberInfo[] memInfo = type.GetMember(en.ToString());

            if (memInfo != null && memInfo.Length > 0)
            {
                object[] attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (attrs != null && attrs.Length > 0)
                {
                    return ((DescriptionAttribute)attrs[0]).Description;
                }
            }

            return en.ToString();
        }

        public static List<T> ToList<T>(T en)
        {
            Type t = typeof(T);

            if (!t.IsEnum)
            {
                throw new ArgumentException("Type provided must be an Enum.", "T");
            }

            return Enum.GetValues(t).Cast<T>().ToList();
        }

        public static T EnumParse<T>(this string value)
        {
            return EnumHelper.EnumParse<T>(value, false);
        }

        public static T EnumParse<T>(this string value, bool ignorecase)
        {

            if (value == null)
            {
                throw new ArgumentNullException("value");
            }

            value = value.Trim();

            if (value.Length == 0)
            {
                throw new ArgumentException("Empty string never parse to an enum", "value");
            }

            Type t = typeof(T);

            if (!t.IsEnum)
            {
                throw new ArgumentException("Type provided must be an Enum.", "T");
            }

            return (T)Enum.Parse(t, value, ignorecase);
        }
    }

}
