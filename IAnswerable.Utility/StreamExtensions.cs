// -----------------------------------------------------------------------
// <copyright file="StreamExtensions.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace IAnswerable.Utility
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
using System.IO;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public static class StreamExtensions
    {
        public static Stream ToStream(this string value)
        {
            byte[] byteArray = Encoding.ASCII.GetBytes(value);
            MemoryStream stream = new MemoryStream(byteArray);
            return stream;
        }

        public static string ToText(this Stream value)
        {
            StreamReader reader = new StreamReader(value);
            string text = reader.ReadToEnd();
            return text;
        }
    }
}
