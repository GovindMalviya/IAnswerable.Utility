using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace IAnswerable.Utility
{
    public static class ValidationExtensions
    {
        public static bool IsValidEmail(this string str)
        {
            return IsRegexMatch(str, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        }

        public static bool IsValidUrl(this string str)
        {
            return IsRegexMatch(str, @"^http(s)?://([\w-]+.)+[\w-]+(/[\w- ./?%&=])?$");
        }

        public static bool IsInt(this string str)
        {
            int num;

            if (int.TryParse(str, out num))
            {
                return true;
            }

            return false;
        }

        public static bool IsDouble(this string str)
        {
            double num;

            if (double.TryParse(str, out num))
            {
                return true;
            }

            return false;
        }

        public static bool IsNumber(this string str)
        {
            return str.IsInt() || str.IsDouble();
        }

        private static bool IsRegexMatch(string str, string pattern)
        {
            Regex regex = new Regex(pattern);

            if (regex.IsMatch(str))
            {
                return true;
            }

            return false;
        }
    }
}
