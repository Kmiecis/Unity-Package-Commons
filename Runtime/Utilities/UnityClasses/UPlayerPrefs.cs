using Common.Extensions;
using System;
using UnityEngine;

namespace Common
{
    public static class UPlayerPrefs
    {
        private const string X_SUFFIX = "-x";
        private const string Y_SUFFIX = "-y";
        private const string Z_SUFFIX = "-z";
        private const string W_SUFFIX = "-w";

        private const string R_SUFFIX = "-r";
        private const string G_SUFFIX = "-g";
        private const string B_SUFFIX = "-b";
        private const string A_SUFFIX = "-a";

        #region Vector2
        public static Vector2 GetVector2(string key, Vector2 defaultValue = default)
        {
            return new Vector2(
                PlayerPrefs.GetFloat(key + X_SUFFIX, defaultValue.x),
                PlayerPrefs.GetFloat(key + Y_SUFFIX, defaultValue.y)
            );
        }

        public static void SetVector2(string key, Vector2 value)
        {
            PlayerPrefs.SetFloat(key + X_SUFFIX, value.x);
            PlayerPrefs.SetFloat(key + Y_SUFFIX, value.y);
        }

        public static bool TryGetVector2(string key, out Vector2 value)
        {
            value = GetVector2(key);
            return (
                PlayerPrefs.HasKey(key + X_SUFFIX) ||
                PlayerPrefs.HasKey(key + Y_SUFFIX)
            );
        }
        #endregion

        #region Vector3
        public static Vector3 GetVector3(string key, Vector3 defaultValue = default)
        {
            return new Vector3(
                PlayerPrefs.GetFloat(key + X_SUFFIX, defaultValue.x),
                PlayerPrefs.GetFloat(key + Y_SUFFIX, defaultValue.y),
                PlayerPrefs.GetFloat(key + Z_SUFFIX, defaultValue.z)
            );
        }

        public static void SetVector3(string key, Vector3 value)
        {
            PlayerPrefs.SetFloat(key + X_SUFFIX, value.x);
            PlayerPrefs.SetFloat(key + Y_SUFFIX, value.y);
            PlayerPrefs.SetFloat(key + Z_SUFFIX, value.z);
        }

        public static bool TryGetVector3(string key, out Vector3 value)
        {
            value = GetVector3(key);
            return (
                PlayerPrefs.HasKey(key + X_SUFFIX) ||
                PlayerPrefs.HasKey(key + Y_SUFFIX) ||
                PlayerPrefs.HasKey(key + Z_SUFFIX)
            );
        }
        #endregion

        #region Vector4
        public static Vector4 GetVector4(string key, Vector4 defaultValue = default)
        {
            return new Vector4(
                PlayerPrefs.GetFloat(key + X_SUFFIX, defaultValue.x),
                PlayerPrefs.GetFloat(key + Y_SUFFIX, defaultValue.y),
                PlayerPrefs.GetFloat(key + Z_SUFFIX, defaultValue.z),
                PlayerPrefs.GetFloat(key + W_SUFFIX, defaultValue.w)
            );
        }

        public static void SetVector4(string key, Vector4 value)
        {
            PlayerPrefs.SetFloat(key + X_SUFFIX, value.x);
            PlayerPrefs.SetFloat(key + Y_SUFFIX, value.y);
            PlayerPrefs.SetFloat(key + Z_SUFFIX, value.z);
            PlayerPrefs.SetFloat(key + W_SUFFIX, value.w);
        }

        public static bool TryGetVector4(string key, out Vector4 value)
        {
            value = GetVector4(key);
            return (
                PlayerPrefs.HasKey(key + X_SUFFIX) ||
                PlayerPrefs.HasKey(key + Y_SUFFIX) ||
                PlayerPrefs.HasKey(key + Z_SUFFIX) ||
                PlayerPrefs.HasKey(key + W_SUFFIX)
            );
        }
        #endregion

        #region Quaternion
        public static Quaternion GetQuaternion(string key, Quaternion defaultValue = default)
        {
            return new Quaternion(
                PlayerPrefs.GetFloat(key + X_SUFFIX, defaultValue.x),
                PlayerPrefs.GetFloat(key + Y_SUFFIX, defaultValue.y),
                PlayerPrefs.GetFloat(key + Z_SUFFIX, defaultValue.z),
                PlayerPrefs.GetFloat(key + W_SUFFIX, defaultValue.w)
            );
        }

        public static void SetQuaternion(string key, Quaternion value)
        {
            PlayerPrefs.SetFloat(key + X_SUFFIX, value.x);
            PlayerPrefs.SetFloat(key + Y_SUFFIX, value.y);
            PlayerPrefs.SetFloat(key + Z_SUFFIX, value.z);
            PlayerPrefs.SetFloat(key + W_SUFFIX, value.w);
        }

        public static bool TryGetQuaternion(string key, out Quaternion value)
        {
            value = GetQuaternion(key);
            return (
                PlayerPrefs.HasKey(key + X_SUFFIX) ||
                PlayerPrefs.HasKey(key + Y_SUFFIX) ||
                PlayerPrefs.HasKey(key + Z_SUFFIX) ||
                PlayerPrefs.HasKey(key + W_SUFFIX)
            );
        }
        #endregion

        #region Vector2Int
        public static Vector2Int GetVector2Int(string key, Vector2Int defaultValue = default)
        {
            return new Vector2Int(
                PlayerPrefs.GetInt(key + X_SUFFIX, defaultValue.x),
                PlayerPrefs.GetInt(key + Y_SUFFIX, defaultValue.y)
            );
        }

        public static void SetVector2Int(string key, Vector2Int value)
        {
            PlayerPrefs.SetInt(key + X_SUFFIX, value.x);
            PlayerPrefs.SetInt(key + Y_SUFFIX, value.y);
        }

        public static bool TryGetVector2Int(string key, out Vector2Int value)
        {
            value = GetVector2Int(key);
            return (
                PlayerPrefs.HasKey(key + X_SUFFIX) ||
                PlayerPrefs.HasKey(key + Y_SUFFIX)
            );
        }
        #endregion

        #region Vector3Int
        public static Vector3Int GetVector3Int(string key, Vector3Int defaultValue = default)
        {
            return new Vector3Int(
                PlayerPrefs.GetInt(key + X_SUFFIX, defaultValue.x),
                PlayerPrefs.GetInt(key + Y_SUFFIX, defaultValue.y),
                PlayerPrefs.GetInt(key + Z_SUFFIX, defaultValue.z)
            );
        }

        public static void SetVector3Int(string key, Vector3Int value)
        {
            PlayerPrefs.SetInt(key + X_SUFFIX, value.x);
            PlayerPrefs.SetInt(key + Y_SUFFIX, value.y);
            PlayerPrefs.SetInt(key + Z_SUFFIX, value.z);
        }

        public static bool TryGetVector3Int(string key, out Vector3Int value)
        {
            value = GetVector3Int(key);
            return (
                PlayerPrefs.HasKey(key + X_SUFFIX) ||
                PlayerPrefs.HasKey(key + Y_SUFFIX) ||
                PlayerPrefs.HasKey(key + Z_SUFFIX)
            );
        }
        #endregion

        #region Color
        public static Color GetColor(string key, Color defaultValue = default)
        {
            return new Color(
                PlayerPrefs.GetFloat(key + R_SUFFIX, defaultValue.r),
                PlayerPrefs.GetFloat(key + G_SUFFIX, defaultValue.g),
                PlayerPrefs.GetFloat(key + B_SUFFIX, defaultValue.b),
                PlayerPrefs.GetFloat(key + A_SUFFIX, defaultValue.a)
            );
        }

        public static void SetColor(string key, Color value)
        {
            PlayerPrefs.SetFloat(key + R_SUFFIX, value.r);
            PlayerPrefs.SetFloat(key + G_SUFFIX, value.g);
            PlayerPrefs.SetFloat(key + B_SUFFIX, value.b);
            PlayerPrefs.SetFloat(key + A_SUFFIX, value.a);
        }

        public static bool TryGetColor(string key, out Color value)
        {
            value = GetColor(key);
            return (
                PlayerPrefs.HasKey(key + R_SUFFIX) ||
                PlayerPrefs.HasKey(key + G_SUFFIX) ||
                PlayerPrefs.HasKey(key + B_SUFFIX) ||
                PlayerPrefs.HasKey(key + A_SUFFIX)
            );
        }
        #endregion

        #region Color32
        public static Color32 GetColor32(string key, Color32 defaultValue = default)
        {
            return new Color32(
                (byte)PlayerPrefs.GetInt(key + R_SUFFIX, defaultValue.r),
                (byte)PlayerPrefs.GetInt(key + G_SUFFIX, defaultValue.g),
                (byte)PlayerPrefs.GetInt(key + B_SUFFIX, defaultValue.b),
                (byte)PlayerPrefs.GetInt(key + A_SUFFIX, defaultValue.a)
            );
        }

        public static void SetColor32(string key, Color32 value)
        {
            PlayerPrefs.SetInt(key + R_SUFFIX, value.r);
            PlayerPrefs.SetInt(key + G_SUFFIX, value.g);
            PlayerPrefs.SetInt(key + B_SUFFIX, value.b);
            PlayerPrefs.SetInt(key + A_SUFFIX, value.a);
        }

        public static bool TryGetColor32(string key, out Color32 value)
        {
            value = GetColor32(key);
            return (
                PlayerPrefs.HasKey(key + R_SUFFIX) ||
                PlayerPrefs.HasKey(key + G_SUFFIX) ||
                PlayerPrefs.HasKey(key + B_SUFFIX) ||
                PlayerPrefs.HasKey(key + A_SUFFIX)
            );
        }
        #endregion

        #region Bool
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
        #endregion

        #region Strings
        public static string[] GetStrings(string key, string[] defaults = null)
        {
            var serialized = PlayerPrefs.GetString(key);
            if (string.IsNullOrEmpty(serialized))
                return defaults;
            return serialized.Split(';');
        }

        public static void SetStrings(string key, string[] values)
        {
            var serialized = values.Join(';');
            PlayerPrefs.SetString(key, serialized);
        }

        public static bool TryGetStrings(string key, out string[] values)
        {
            values = GetStrings(key);
            return values != null;
        }
        #endregion

        #region Values
        public static T[] GetValues<T>(string key, Func<string, T> deserializer, T[] defaults = null)
        {
            var serialized = PlayerPrefs.GetString(key);
            if (string.IsNullOrEmpty(serialized))
                return defaults;

            var serializable = serialized.Split(';');
            var result = new T[serializable.Length];
            for (int i = 0; i < serializable.Length; ++i)
                result[i] = deserializer(serializable[i]);
            return result;
        }

        public static void SetValues<T>(string key, T[] values, Func<T, string> serializer)
        {
            var serializable = new string[values.Length];
            for (int i = 0; i < values.Length; ++i)
                serializable[i] = serializer(values[i]);

            var serialized = serializable.Join(';');
            PlayerPrefs.SetString(key, serialized);
        }

        public static bool TryGetValues<T>(string key, Func<string, T> serializer, out T[] values)
        {
            values = GetValues(key, serializer);
            return values != null;
        }
        #endregion

        #region Core
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
        #endregion
    }
}