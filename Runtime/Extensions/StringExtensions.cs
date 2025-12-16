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

        public static int Count(this string self, string needle)
        {
            return (self.Length - self.Replace(needle, string.Empty).Length) / needle.Length;
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

        public static string Extract(this string self, char left, char right)
        {
            var startIndex = self.IndexOf(left);
            var endIndex = self.IndexOf(right);
            if (endIndex == -1) endIndex = self.Length;
            return self.Substring(startIndex + 1, endIndex - startIndex - 1);
        }

        public static string AsBackingField(this string self)
        {
            return $"<{self}>k__BackingField";
        }

        public static string RichAlign(this string self, string alignment)
        {
            return $"<align=\"{alignment}\">{self}</align>";
        }

        public static string RichAlpha(this string self, string alpha)
        {
            return $"<alpha={alpha}>{self}</alpha>";
        }

        public static string RichBold(this string self)
        {
            return $"<b>{self}</b>";
        }

        public static string RichBreakPrefix(this string self)
        {
            return $"<br>{self}";
        }

        public static string RichBreakSuffix(this string self)
        {
            return $"{self}<br>";
        }

        public static string RichColor(this string self, string color)
        {
            return $"<color={color}>{self}</color>";
        }

        public static string RichFont(this string self, string font)
        {
            return $"<font=\"{font}\">{self}</font>";
        }

        public static string RichFontWeight(this string self, int weight)
        {
            return $"<font-weight=\"{weight}\">{self}</font-weight>";
        }

        public static string RichGradient(this string self, string gradient)
        {
            return $"<gradient=\"{gradient}\">{self}</gradient>";
        }

        public static string RichHyperlink(this string self, string url)
        {
            return $"<a href=\"{url}\">{self}</a>";
        }

        public static string RichIndent(this string self, int percent)
        {
            return $"<indent={percent}%>{self}</indent>";
        }

        public static string RichItalic(this string self)
        {
            return $"<i>{self}</i>";
        }

        public static string RichLineHeight(this string self, int percent)
        {
            return $"<line-height={percent}%>{self}</line-height>";
        }

        public static string RichLineIndent(this string self, int percent)
        {
            return $"<line-indent={percent}%>{self}</line-indent>";
        }

        public static string RichLink(this string self, string id)
        {
            return $"<link=\"{id}\">{self}</link>";
        }

        public static string RichLowercase(this string self)
        {
            return $"<lowercase>{self}</lowercase>";
        }

        public static string RichMargin(this string self, int margin)
        {
            return $"<margin={margin}em>{self}</margin>";
        }

        public static string RichMarginLeft(this string self, int margin)
        {
            return $"<margin-left={margin}em>{self}</margin-left>";
        }

        public static string RichMarginRight(this string self, int margin)
        {
            return $"<margin-right={margin}em>{self}</margin-right>";
        }

        public static string RichMark(this string self, string mark)
        {
            return $"<mark={mark}>{self}</mark>";
        }

        public static string RichMonospace(this string self, float monospace)
        {
            return $"<mspace={monospace}em>{self}</mspace>";
        }

        public static string RichNoBreak(this string self)
        {
            return $"<nobr>{self}</nobr>";
        }

        public static string RichNoParse(this string self)
        {
            return $"<noparse>{self}</noparse>";
        }

        public static string RichRotate(this string self, int angle)
        {
            return $"<rotate=\"{angle}\">{self}</rotate>";
        }

        public static string RichSize(this string self, int size)
        {
            return $"<size={size}>{self}</size>";
        }

        public static string RichSpace(this string self, float space)
        {
            return $"<space={space}em>{self}</space>";
        }

        public static string RichSpritePrefix(this string self, string spritename)
        {
            return $"<sprite name=\"{spritename}\">{self}";
        }

        public static string RichSpriteSuffix(this string self, string spritename)
        {
            return $"{self}<sprite name=\"{spritename}\">";
        }

        public static string RichStrikethrough(this string self)
        {
            return $"<s>{self}</s>";
        }

        public static string RichStyle(this string self, string style)
        {
            return $"<style=\"{style}\">{self}</style>";
        }

        public static string RichUnderline(this string self)
        {
            return $"<u>{self}</u>";
        }

        public static string RichUppercase(this string self)
        {
            return $"<uppercase>{self}</uppercase>";
        }

        public static string RichWidth(this string self, int percent)
        {
            return $"<width={percent}%>{self}</width>";
        }
    }
}
