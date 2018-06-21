using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using static System.IO.Path;

namespace Extensions
{
    public static class StringExtensions
    {
        public static T ToEnum<T>(this string str) where T : struct
        {
            try
            {
                return str == null ? default : (T)Enum.Parse(typeof(T), str, true);
            }
            catch (ArgumentException e)
            {
                throw new ArgumentException($"Cannot parse {str} to {typeof(T).Name}", e);
            }
        }

        public static bool IsEqualsTo(this string str, string strToCompare) => IsEqualsTo(str, strToCompare, false);

        public static bool IsEqualsTo(this string str, string strToCompare, bool caseSensitive)
            => string.Equals(str, strToCompare, caseSensitive ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase);

        public static string Absolutize(this string path)
            => IsPathRooted(path) ? path : Combine(Directory.GetCurrentDirectory(), path);

        public static string Slice(this string source, int start, int end)
        {
            if (end < 0) // Keep this for negative end support
                end = source.Length + end;
            var len = end - start; // Calculate length
            return source.Substring(start, len); // Return Substring of length
        }

        public static string ToStringOrEmpty(this object value)
        {
            return string.Concat(value, "");
        }

        public static string FromCamelCase(this string source)
        {
            string returnValue = source.ToStringOrEmpty();

            //Strip leading "_" character
            returnValue = Regex.Replace(returnValue, "^_", "").Trim();
            //Add a space between each lower case character and upper case character
            returnValue = Regex.Replace(returnValue, "([a-z])([A-Z])", "$1 $2").Trim();
            //Add a space between 2 upper case characters when the second one is followed by a lower space character
            returnValue = Regex.Replace(returnValue, "([A-Z])([A-Z][a-z])", "$1 $2").Trim();

            return returnValue;
        }

        public static string ReplaceWith(this string value, string newValue) => newValue.IsNullOrEmpty() ? value : newValue;

        public static bool IsNullOrEmpty(this string value) => string.IsNullOrEmpty(value);

        public static bool IsNullOrWhiteSpace(this string value) => string.IsNullOrWhiteSpace(value);

        public static bool IsNumeric(this string value)
        {
            return long.TryParse(value, NumberStyles.Integer, NumberFormatInfo.InvariantInfo, out long retNum);
        }

        public static IEnumerable<string> SplitString(this string s) =>
            s.ToCharArray().Select(x => x.ToString());

        public static string CenterString(this string stringToCenter, int totalLength)
        {
            return stringToCenter.PadLeft(((totalLength - stringToCenter.Length) / 2)
                                + stringToCenter.Length)
                       .PadRight(totalLength);
        }

        public static string Reverse(this string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
