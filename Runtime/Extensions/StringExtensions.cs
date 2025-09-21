using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Common
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

        public static string NonNull(this string self)
        {
            return !self.IsNull() ? self : string.Empty;
        }

        public static string NonEmpty(this string self)
        {
            return self.IsNull() || !self.IsEmpty() ? self : null;
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

        public static string[] GetLines(this string self)
        {
            return self.Split(new []{ "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
        }

        public static string Capitalize(this string self)
        {
            if (string.IsNullOrEmpty(self))
                return self;
            if (self.Length == 1)
                return char.ToUpper(self[0]).ToString();
            else
                return char.ToUpper(self[0]) + self.Substring(1);
        }

        public static string Decapitalize(this string self)
        {
            if (string.IsNullOrEmpty(self))
                return self;
            if (self.Length == 1)
                return char.ToLower(self[0]).ToString();
            else
                return char.ToLower(self[0]) + self.Substring(1);
        }

        public static bool StartsWith(this string self, string prefix)
        {
            if (string.IsNullOrEmpty(self) || string.IsNullOrEmpty(prefix))
                return false;

            var valueLength = self.Length;
            var prefixLength = prefix.Length;
            if (valueLength < prefixLength)
                return false;

            for (int i = 0; i < prefixLength; i++)
                if (self[i] != prefix[i])
                    return false;
            return true;
        }

        public static bool EndsWith(this string self, string suffix)
        {
            if (string.IsNullOrEmpty(self) || string.IsNullOrEmpty(suffix))
                return false;

            var valueLength = self.Length;
            var suffixLength = suffix.Length;
            if (valueLength < suffixLength)
                return false;

            for (int i = 0; i < suffixLength; i++)
                if (self[valueLength - suffixLength + i] != suffix[i])
                    return false;
            return true;
        }

        public static string Remove(this string self, char value)
        {
            if (self.TryIndexOf(value, out int index))
                return self.Remove(index, 1);
            return self;
        }

        public static string Remove(this string self, string value)
        {
            if (self.TryIndexOf(value, out int index))
                return self.Remove(index, value.Length);
            return self;
        }

        public static string RemoveAll(this string self, char value)
        {
            while (self.TryIndexOf(value, out int index))
                self = self.Remove(index, 1);
            return self;
        }

        public static string RemoveAll(this string self, string value)
        {
            while (self.TryIndexOf(value, out int index))
                self = self.Remove(index, value.Length);
            return self;
        }

        public static string RemovePrefix(this string self, string prefix)
        {
            if (StartsWith(self, prefix))
                return self.Substring(prefix.Length);
            return self;
        }

        public static string RemoveSuffix(this string self, string suffix)
        {
            if (EndsWith(self, suffix))
                return self.Substring(0, self.Length - suffix.Length);
            return self;
        }

        public static string Replace(this string self, string oldValue, object newValue)
        {
            return self.Replace(oldValue, newValue.ToString());
        }

        public static string[] Split(this string self, int count)
        {
            int length = self.Length / count;
            var result = new string[length];
            for (int i = 0; i < result.Length; ++i)
                result[i] = self.Substring(i * count, count);
            return result;
        }

        public static string[] SplitByCamelCase(this string self)
        {
            return Regex.Split(self, @"(?<!^)(?=[A-Z])");
        }

        public static string Join(this IList<string> self, char separator)
        {
            return string.Join(separator, self);
        }

        public static string Join(this IList<string> self, char separator, int startIndex, int count)
        {
            return string.Join(separator, self, startIndex, count);
        }

        public static string Join(this IList<string> self, string separator)
        {
            return string.Join(separator, self);
        }

        public static string Join(this IList<string> self, string separator, int startIndex, int count)
        {
            return string.Join(separator, self, startIndex, count);
        }

        public static string RichBold(this string self)
        {
            return $"<b>{self}</b>";
        }

        public static string RichColor(this string self, string color)
        {
            return $"<color={color}>{self}</color>";
        }

        public static string RichItalic(this string self)
        {
            return $"<i>{self}</i>";
        }

        public static string RichLink(this string self, string id)
        {
            return $"<link={id}>{self}</link>";
        }

        public static string RichSize(this string self, int size)
        {
            return $"<size={size}>{self}</size>";
        }

        public static string RichStrikethrough(this string self)
        {
            return $"<s>{self}</s>";
        }

        public static string RichUnderline(this string self)
        {
            return $"<u>{self}</u>";
        }
    }
}
