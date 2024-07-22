using System;
using UnityEngine;

namespace Common
{
    public static class UPlayerPrefs
    {
        public static bool GetBool(string key, bool defaultValue = false)
        {
            var intValue = Convert.ToInt32(defaultValue);
            intValue = PlayerPrefs.GetInt(key, intValue);
            return Convert.ToBoolean(intValue);
        }

        public static void SetBool(string key, bool value)
        {
            var intValue = Convert.ToInt32(value);
            PlayerPrefs.SetInt(key, intValue);
        }

        public static bool TryGetBool(string key, out bool value)
        {
            value = GetBool(key);
            return PlayerPrefs.HasKey(key);
        }

        public static bool TryGetInt(string key, out int value)
        {
            value = PlayerPrefs.GetInt(key);
            return PlayerPrefs.HasKey(key);
        }

        public static bool TryGetFloat(string key, out float value)
        {
            value = PlayerPrefs.GetFloat(key);
            return PlayerPrefs.HasKey(key);
        }

        public static bool TryGetString(string key, out string value)
        {
            value = PlayerPrefs.GetString(key);
            return PlayerPrefs.HasKey(key);
        }

        public static bool[] GetBools(string key, bool[] defaultValue = null)
        {
            var keyValue = PlayerPrefs.GetString(key);
            if (string.IsNullOrEmpty(keyValue))
                return defaultValue;
            var values = keyValue.Split(';');
            var result = new bool[values.Length];
            for (int i = 0; i < values.Length; ++i)
                result[i] = Convert.ToBoolean(Convert.ToInt32(values[i]));
            return result;
        }

        public static void SetBools(string key, bool[] values)
        {
            var strings = new string[values.Length];
            for (int i = 0; i < values.Length; ++i)
                strings[i] = Convert.ToString(Convert.ToInt32(values[i]));
            var keyValue = string.Join(';', strings);
            PlayerPrefs.SetString(key, keyValue);
        }

        public static bool TryGetBools(string key, out bool[] values)
        {
            values = GetBools(key);
            return values != null;
        }
    }
}