using System;
using UnityEngine;

namespace Common
{
    public static class StringExtensions
    {
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