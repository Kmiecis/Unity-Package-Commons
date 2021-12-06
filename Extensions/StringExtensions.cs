using System;
using UnityEngine;

namespace Common.Extensions
{
    public static class StringExtensions
    {
        public static bool IsNull(this string self)
        {
            return self == null;
        }

        public static bool IsEmpty(this string self)
        {
            return self.Length == 0;
        }

        public static bool IsNullOrEmpty(this string self)
        {
            return self.IsNull() || self.IsEmpty();
        }

        public static bool TryIndexOf(this string self, char value, out int index)
        {
            index = self.IndexOf(value);
            return index != -1;
        }

        public static bool TryIndexOf(this string self, char value, int startIndex, out int index)
        {
            index = self.IndexOf(value, startIndex);
            return index != -1;
        }

        public static bool TryIndexOf(this string self, char value, int startIndex, int count, out int index)
        {
            index = self.IndexOf(value, startIndex, count);
            return index != -1;
        }

        public static bool TryIndexOf(this string self, string value, out int index)
        {
            index = self.IndexOf(value);
            return index != -1;
        }

        public static bool TryIndexOf(this string self, string value, int startIndex, out int index)
        {
            index = self.IndexOf(value, startIndex);
            return index != -1;
        }

        public static bool TryIndexOf(this string self, string value, int startIndex, int count, out int index)
        {
            index = self.IndexOf(value, startIndex, count);
            return index != -1;
        }

        public static bool TryIndexOf(this string self, string value, StringComparison comparisonType, out int index)
        {
            index = self.IndexOf(value, comparisonType);
            return index != -1;
        }

        public static bool TryIndexOf(this string self, string value, int startIndex, StringComparison comparisonType, out int index)
        {
            index = self.IndexOf(value, startIndex, comparisonType);
            return index != -1;
        }

        public static bool TryIndexOf(this string self, string value, int startIndex, int count, StringComparison comparisonType, out int index)
        {
            index = self.IndexOf(value, startIndex, count, comparisonType);
            return index != -1;
        }

        public static bool TryIndexOfAny(this string self, char[] anyOf, out int index)
        {
            index = self.IndexOfAny(anyOf);
            return index != -1;
        }

        public static bool TryIndexOfAny(this string self, char[] anyOf, int startIndex, out int index)
        {
            index = self.IndexOfAny(anyOf, startIndex);
            return index != -1;
        }

        public static bool TryIndexOfAny(this string self, char[] anyOf, int startIndex, int count, out int index)
        {
            index = self.IndexOfAny(anyOf, startIndex, count);
            return index != -1;
        }

        public static bool TryLastIndexOf(this string self, char value, out int index)
        {
            index = self.LastIndexOf(value);
            return index != -1;
        }

        public static bool TryLastIndexOf(this string self, char value, int startIndex, out int index)
        {
            index = self.LastIndexOf(value, startIndex);
            return index != -1;
        }

        public static bool TryLastIndexOf(this string self, char value, int startIndex, int count, out int index)
        {
            index = self.LastIndexOf(value, startIndex, count);
            return index != -1;
        }

        public static bool TryLastIndexOf(this string self, string value, out int index)
        {
            index = self.LastIndexOf(value);
            return index != -1;
        }

        public static bool TryLastIndexOf(this string self, string value, int startIndex, out int index)
        {
            index = self.LastIndexOf(value, startIndex);
            return index != -1;
        }

        public static bool TryLastIndexOf(this string self, string value, int startIndex, int count, out int index)
        {
            index = self.LastIndexOf(value, startIndex, count);
            return index != -1;
        }

        public static bool TryLastIndexOf(this string self, string value, StringComparison comparisonType, out int index)
        {
            index = self.LastIndexOf(value, comparisonType);
            return index != -1;
        }

        public static bool TryLastIndexOf(this string self, string value, int startIndex, StringComparison comparisonType, out int index)
        {
            index = self.LastIndexOf(value, startIndex, comparisonType);
            return index != -1;
        }

        public static bool TryLastIndexOf(this string self, string value, int startIndex, int count, StringComparison comparisonType, out int index)
        {
            index = self.LastIndexOf(value, startIndex, count, comparisonType);
            return index != -1;
        }

        public static bool TryLastIndexOfAny(this string self, char[] anyOf, out int index)
        {
            index = self.LastIndexOfAny(anyOf);
            return index != -1;
        }

        public static bool TryLastIndexOfAny(this string self, char[] anyOf, int startIndex, out int index)
        {
            index = self.LastIndexOfAny(anyOf, startIndex);
            return index != -1;
        }

        public static bool TryLastIndexOfAny(this string self, char[] anyOf, int startIndex, int count, out int index)
        {
            index = self.LastIndexOfAny(anyOf, startIndex, count);
            return index != -1;
        }

        public static string[] GetLines(this string value)
        {
            return value.Split(new []{ "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
        }

        public static Color32 HexToColorRGB(this string value)
        {
            byte r = Convert.ToByte(value.Substring(0, 2), 16);
            byte g = Convert.ToByte(value.Substring(2, 2), 16);
            byte b = Convert.ToByte(value.Substring(4, 2), 16);
            return new Color32(r, g, b, 255);
        }

        public static Color32 HexToColorRGBA(this string value)
        {
            byte r = Convert.ToByte(value.Substring(0, 2), 16);
            byte g = Convert.ToByte(value.Substring(2, 2), 16);
            byte b = Convert.ToByte(value.Substring(4, 2), 16);
            byte a = Convert.ToByte(value.Substring(6, 2), 16);
            return new Color32(r, g, b, a);
        }

        public static string Capitalize(this string value)
        {
            if (string.IsNullOrEmpty(value))
                return value;
            if (value.Length == 1)
                return char.ToUpper(value[0]).ToString();
            else
                return char.ToUpper(value[0]) + value.Substring(1);
        }

        public static bool StartsWith(this string value, string prefix)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrEmpty(prefix))
                return false;

            var valueLength = value.Length;
            var prefixLength = prefix.Length;
            if (valueLength < prefixLength)
                return false;

            for (int i = 0; i < prefixLength; i++)
                if (value[i] != prefix[i])
                    return false;
            return true;
        }

        public static bool EndsWith(this string value, string suffix)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrEmpty(suffix))
                return false;

            var valueLength = value.Length;
            var suffixLength = suffix.Length;
            if (valueLength < suffixLength)
                return false;

            for (int i = 0; i < suffixLength; i++)
                if (value[valueLength - suffixLength + i] != suffix[i])
                    return false;
            return true;
        }

        public static string RemovePrefix(this string value, string prefix)
        {
            if (StartsWith(value, prefix))
                return value.Substring(prefix.Length);
            return value;
        }

        public static string RemoveSuffix(this string value, string suffix)
        {
            if (EndsWith(value, suffix))
                return value.Substring(0, value.Length - suffix.Length);
            return value;
        }
    }
}
