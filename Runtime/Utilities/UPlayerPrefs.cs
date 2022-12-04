using UnityEngine;

namespace Common
{
    public static class UPlayerPrefs
    {
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
    }
}
